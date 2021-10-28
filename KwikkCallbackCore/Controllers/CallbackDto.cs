using System;

namespace KwikkCallbackCore
{
    public class CallbackDto
    {
        public string orderid { get; set; }
        public string artnr { get; set; }
        public string art_spec { get; set; }
        public string totalprice { get; set; }
        public string vat_amount { get; set; }
        public string phone { get; set; }
        public string order_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string postal { get; set; }
        public string city { get; set; }
        public string buyer_email { get; set; }
        public string buyer_email_sent { get; set; }
        public string lifetime { get; set; }
        public string orderreference { get; set; }
        public string refund_for_order { get; set; }
        public string token { get; set; }
        public string appCallbackUrl { get; set; }
        public string approvedTerms { get; set; }
        public string payout_id { get; set; }
        public string payout_us_id { get; set; }
        public string fee { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public string orderKey { get; set; }
        public string callbackid { get; set; }
        public string transactionId { get; set; }
        public string paymentReference { get; set; }
        public string originalPaymentReference { get; set; }
        public string payeePaymentReference { get; set; }
        public string paymentRequestToken { get; set; }
        public string payerAlias { get; set; }
        public string payeeAlias { get; set; }
        public string message { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime datePaid { get; set; }
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
        public string updatedBy { get; set; }
        public string expires { get; set; }
        public string expired { get; set; }
        public string callback_created { get; set; }
        public string callback_updated { get; set; }
        public string payment_method { get; set; }
    }
}