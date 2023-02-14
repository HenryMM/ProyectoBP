
namespace App.BP.Common.DTO
{
    public class TarjetaInformacion
    {
        public string CARD_INSTITUTION { get; set; }
        public string CARD_NUMBER { get; set; }
        public string CARD_NETWORK_ID { get; set; }
        public string CARD_OWNER_ID_TYPE { get; set; }
        public string CARD_OWNER_ID { get; set; }
        public string CARD_CUSTOMER_CARD_NAME { get; set; }
        public DateTime CARD_ISSUE_DATE { get; set; }
        public string CARD_ISSUE_OFFICE { get; set; }
        public DateTime CARD_DELIVERY_DATE { get; set; }
        public string CARD_DELIVERY_OFFICE { get; set; }
        public DateTime CARD_REISSUE_DATE { get; set; }
        public DateTime CARD_EXPIRATION_DATE { get; set; }
        public string CARD_TYPE { get; set; }
        public string CARD_STATUS { get; set; }
        public DateTime CARD_LAST_STATUS_CHANGE { get; set; }
        public DateTime CARD_FIRST_USE_DATE { get; set; }
        public DateTime CARD_LAST_USE_DATE { get; set; }
        public decimal CARD_WD_LIMIT { get; set; }
        public decimal CARD_WD_USED { get; set; }
        public decimal CARD_XFR_LIMIT { get; set; }
        public decimal CARD_XFR_USED { get; set; }
        public decimal CARD_XFR_OTHERS_LIMIT { get; set; }
        public decimal CARD_XFR_OTHERS_USED { get; set; }
        public decimal CARD_POS_LIMIT { get; set; }
        public decimal CARD_POS_USED { get; set; }
        public decimal CARD_MOB_LIMIT { get; set; }
        public decimal CARD_MOB_USED { get; set; }
        public int CARD_WD_COUNT_LIMIT { get; set; }
        public int CARD_WD_COUNT { get; set; }
        public int CARD_XFR_COUNT_LIMIT { get; set; }
        public int CARD_XFR_COUNT { get; set; }
        public int CARD_POS_COUNT_LIMIT { get; set; }
        public int CARD_POS_COUNT { get; set; }
        public int CARD_MOB_COUNT_LIMIT { get; set; }
        public int CARD_MOB_COUNT { get; set; }
        public int CARD_LIMIT_RESET_PERIOD { get; set; }
        public string CARD_MANDATORY_PIN_CHANGE { get; set; }
        public string CARD_PIN_OFFSET { get; set; }
        public int CARD_PIN_FAIL_LIMIT { get; set; }
        public int CARD_PIN_FAIL_COUNT { get; set; }
        public byte? CARD_ACCT_COUNT { get; set; }
        public DateTime CARD_LAST_PIN_CHANGE { get; set; }
        public DateTime CARD_NEXT_PIN_CHANGE { get; set; }
        public decimal CARD_TNP_LIMIT { get; set; }
        public decimal CARD_TNP_USED { get; set; }
        public int CARD_TNP_COUNT_LIMIT { get; set; }
        public int CARD_TNP_COUNT { get; set; }
    }
}

