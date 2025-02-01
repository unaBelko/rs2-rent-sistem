import 'package:flutter/material.dart';
import 'package:hooks_riverpod/hooks_riverpod.dart';
import 'package:intl/intl.dart';
import 'package:rs2_rent_sistem/pages/desktop_app_pages/pdf_viewer.dart';
import 'package:rs2_rent_sistem/shared/constants.dart';

class ReportsPage extends ConsumerStatefulWidget {
  const ReportsPage({super.key});

  @override
  ConsumerState<ReportsPage> createState() => _ReportsPageState();
}

class _ReportsPageState extends ConsumerState<ReportsPage> {
  DateTimeRange? selectedDateRange;

  Future<void> _pickDateRange(BuildContext context) async {
    DateTimeRange? picked = await showDateRangePicker(
      context: context,
      firstDate: DateTime(2023, 1, 1),
      lastDate: DateTime.now(),
      initialDateRange: selectedDateRange,
    );

    if (picked != null && mounted) {
      setState(() {
        selectedDateRange = picked;
      });
    }
  }

  void _openReport(String reportType) {
    if (selectedDateRange == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
            content: Text("Odaberite vremensko razdoblje za izvjestaj!")),
      );
      return;
    }

    String formattedStart =
        DateFormat('dd-MM-yyyy').format(selectedDateRange!.start);
    String formattedEnd =
        DateFormat('dd-MM-yyyy').format(selectedDateRange!.end);

    String reportUrl =
        '${Constants.apiUrl}api/Reports/GenerateReport?reportType=$reportType&startDate=$formattedStart&endDate=$formattedEnd';

    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) => PdfViewerWidget(
          pdfPathOrUrl: reportUrl,
          isUrl: true,
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(16.0),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          ElevatedButton.icon(
            onPressed: () => _pickDateRange(context),
            icon: const Icon(Icons.date_range),
            label: Text(selectedDateRange == null
                ? "Odaberite vremensko razdoblje"
                : "${DateFormat('dd.MM.yyyy').format(selectedDateRange!.start)} - ${DateFormat('dd.MM.yyyy').format(selectedDateRange!.end)}"),
          ),
          const SizedBox(height: 16),

          // 📊 Report Type Tiles
          Expanded(
            child: ListView(
              children: [
                _buildReportTile("Oprema po broju iznajmljivanja",
                    Icons.insert_chart, "financial"),
                _buildReportTile("Najaktivniji korisnici",
                    Icons.people_alt_outlined, "usage"),
                _buildReportTile(
                    "Zarada po opremi", Icons.attach_money, "revenue"),
              ],
            ),
          ),
        ],
      ),
    );
  }

  /// 🔹 Creates a report selection tile
  Widget _buildReportTile(String title, IconData icon, String reportType) {
    return Card(
      child: ListTile(
        leading: Icon(icon, size: 32, color: Colors.blue),
        title: Text(title, style: const TextStyle(fontSize: 18)),
        trailing: const Icon(Icons.arrow_forward),
        onTap: () => _openReport(reportType),
      ),
    );
  }
}
