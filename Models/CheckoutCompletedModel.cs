using Nop.Web.Framework.Models;

namespace Nop.Plugin.Payments.PlatiOnline.Models
{
	public record CheckoutCompletedModel : BaseNopModel
	{
		public string Response_reason_text { get; set; }
		public string Order_number { get; set; }
		public string Order_status { get; set; }
		public string Payment_status { get; set; }
	}
}