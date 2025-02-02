import 'dart:developer';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:rs2_rent_sistem/shared/utilities/secure_storage_handler.dart';
import 'package:syncfusion_flutter_pdfviewer/pdfviewer.dart';
import 'package:file_picker/file_picker.dart';
import 'package:printing/printing.dart';
import 'package:http/http.dart' as http;
import 'package:path_provider/path_provider.dart';

class PdfViewerWidget extends StatefulWidget {
  final String pdfPathOrUrl;
  final bool isUrl;

  const PdfViewerWidget(
      {super.key, required this.pdfPathOrUrl, this.isUrl = false});

  @override
  State<PdfViewerWidget> createState() => _PdfViewerWidgetState();
}

class _PdfViewerWidgetState extends State<PdfViewerWidget> {
  late PdfViewerController _pdfViewerController;
  String? _downloadedFilePath;
  bool _isLoading = true;

  @override
  void initState() {
    super.initState();
    _pdfViewerController = PdfViewerController();
    _preparePdf();
  }

  Future<void> _preparePdf() async {
    log('token je ${SecureStorageHandler.token}');
    log('path je ${widget.pdfPathOrUrl}');
    if (widget.isUrl) {
      try {
        final response =
            await http.get(Uri.parse(widget.pdfPathOrUrl), headers: {
          "Authorization": "Bearer ${SecureStorageHandler.token}",
        });
        if (response.statusCode == 200) {
          final tempDir = await getTemporaryDirectory();
          final tempFile = File('${tempDir.path}/temp.pdf');
          await tempFile.writeAsBytes(response.bodyBytes);
          setState(() {
            _downloadedFilePath = tempFile.path;
            _isLoading = false;
          });
        } else {
          throw Exception("Failed to load PDF");
        }
      } catch (e) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text("PDF fajl se ne moze ucitati: $e")),
        );
      }
    } else {
      setState(() {
        _downloadedFilePath = widget.pdfPathOrUrl;
        _isLoading = false;
      });
    }
  }

  Future<void> _downloadPdf() async {
    if (_downloadedFilePath == null) return;
    try {
      String? outputPath = await FilePicker.platform.saveFile(
        dialogTitle: 'Spremi izvjestaj',
        fileName: 'document.pdf',
        type: FileType.custom,
        allowedExtensions: ['pdf'],
      );

      if (outputPath != null) {
        File(_downloadedFilePath!).copySync(outputPath);
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(content: Text("Izvjestaj je uspjesno spremljen!")),
        );
      }
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Download nije uspio: $e")),
      );
    }
  }

  Future<void> _printPdf() async {
    if (_downloadedFilePath == null) return;
    try {
      File pdfFile = File(_downloadedFilePath!);
      await Printing.layoutPdf(
        onLayout: (format) async => pdfFile.readAsBytes(),
      );
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Printanje nije uspjelo: $e")),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blueGrey,
        title: const Text("Izvjestaj"),
        actions: [
          if (!_isLoading)
            IconButton(
              icon: const Icon(Icons.download),
              tooltip: "Preuzimanje PDF-a",
              onPressed: _downloadPdf,
            ),
          if (!_isLoading)
            IconButton(
              icon: const Icon(Icons.print),
              tooltip: "Print PDF",
              onPressed: _printPdf,
            ),
        ],
      ),
      body: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : SfPdfViewer.file(
              File(_downloadedFilePath!),
              controller: _pdfViewerController,
            ),
    );
  }
}
