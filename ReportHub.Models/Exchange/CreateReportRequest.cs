using System.ComponentModel.DataAnnotations;

namespace ReportHub.Models.Exchange;

public class CreateReportRequest
{
    public string Id { get; set; }

    public string Entity { get; set; }

    public string DisplayName { get; set; }

    public string Description { get; set; }

    public IDictionary<string, string> ColumnMap { get; set; }
    
    public IList<string> Columns { get; set; }
    
    public IDictionary<AggregationMode, IList<string>> AggregateColumnMap { get; set; }
    
    public IDictionary<RoundingType, IList<string>> RoundingTypeColumnMap { get; set; }

    public string AddBy { get; set; }
    
    public DateTime AddDate { get; set; }
}