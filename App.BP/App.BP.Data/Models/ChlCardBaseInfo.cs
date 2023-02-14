using System;
using System.Collections.Generic;

namespace App.BP.Data.Models;

public partial class ChlCardBaseInfo
{
    public string CardInstitution { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public string CardNetworkId { get; set; } = null!;

    public string CardOwnerIdType { get; set; } = null!;

    public string CardOwnerId { get; set; } = null!;

    public string CardCustomerCardName { get; set; } = null!;

    public DateTime CardIssueDate { get; set; }

    public string CardIssueOffice { get; set; } = null!;

    public DateTime CardDeliveryDate { get; set; }

    public string CardDeliveryOffice { get; set; } = null!;

    public DateTime CardReissueDate { get; set; }

    public DateTime CardExpirationDate { get; set; }

    public string CardType { get; set; } = null!;

    public string CardStatus { get; set; } = null!;

    public DateTime CardLastStatusChange { get; set; }

    public DateTime CardFirstUseDate { get; set; }

    public DateTime CardLastUseDate { get; set; }

    public decimal CardWdLimit { get; set; }

    public decimal CardWdUsed { get; set; }

    public decimal CardXfrLimit { get; set; }

    public decimal CardXfrUsed { get; set; }

    public decimal CardXfrOthersLimit { get; set; }

    public decimal CardXfrOthersUsed { get; set; }

    public decimal CardPosLimit { get; set; }

    public decimal CardPosUsed { get; set; }

    public decimal CardMobLimit { get; set; }

    public decimal CardMobUsed { get; set; }

    public byte CardWdCountLimit { get; set; }

    public byte CardWdCount { get; set; }

    public byte CardXfrCountLimit { get; set; }

    public byte CardXfrCount { get; set; }

    public byte CardPosCountLimit { get; set; }

    public byte CardPosCount { get; set; }

    public byte CardMobCountLimit { get; set; }

    public byte CardMobCount { get; set; }

    public byte CardLimitResetPeriod { get; set; }

    public string CardMandatoryPinChange { get; set; } = null!;

    public string CardPinOffset { get; set; } = null!;

    public byte CardPinFailLimit { get; set; }

    public byte CardPinFailCount { get; set; }

    public byte? CardAcctCount { get; set; }

    public string? CardAcctType1 { get; set; }

    public string? CardAcctNumber1 { get; set; }

    public string? CardAcctUse1 { get; set; }

    public string? CardAcctType2 { get; set; }

    public string? CardAcctNumber2 { get; set; }

    public string? CardAcctUse2 { get; set; }

    public string? CardAcctType3 { get; set; }

    public string? CardAcctNumber3 { get; set; }

    public string? CardAcctUse3 { get; set; }

    public string? CardAcctType4 { get; set; }

    public string? CardAcctNumber4 { get; set; }

    public string? CardAcctUse4 { get; set; }

    public string? CardAcctType5 { get; set; }

    public string? CardAcctNumber5 { get; set; }

    public string? CardAcctUse5 { get; set; }

    public string? CardAcctType6 { get; set; }

    public string? CardAcctNumber6 { get; set; }

    public string? CardAcctUse6 { get; set; }

    public string? CardAcctType7 { get; set; }

    public string? CardAcctNumber7 { get; set; }

    public string? CardAcctUse7 { get; set; }

    public string? CardAcctType8 { get; set; }

    public string? CardAcctNumber8 { get; set; }

    public string? CardAcctUse8 { get; set; }

    public string? CardAcctType9 { get; set; }

    public string? CardAcctNumber9 { get; set; }

    public string? CardAcctUse9 { get; set; }

    public string? CardAcctType10 { get; set; }

    public string? CardAcctNumber10 { get; set; }

    public string? CardAcctUse10 { get; set; }

    public string? CardAcctType11 { get; set; }

    public string? CardAcctNumber11 { get; set; }

    public string? CardAcctUse11 { get; set; }

    public string? CardAcctType12 { get; set; }

    public string? CardAcctNumber12 { get; set; }

    public string? CardAcctUse12 { get; set; }

    public string? CardAcctType13 { get; set; }

    public string? CardAcctNumber13 { get; set; }

    public string? CardAcctUse13 { get; set; }

    public string? CardAcctType14 { get; set; }

    public string? CardAcctNumber14 { get; set; }

    public string? CardAcctUse14 { get; set; }

    public string? CardAcctType15 { get; set; }

    public string? CardAcctNumber15 { get; set; }

    public string? CardAcctUse15 { get; set; }

    public string? CardAcctType16 { get; set; }

    public string? CardAcctNumber16 { get; set; }

    public string? CardAcctUse16 { get; set; }

    public string? CardAcctType17 { get; set; }

    public string? CardAcctNumber17 { get; set; }

    public string? CardAcctUse17 { get; set; }

    public string? CardAcctType18 { get; set; }

    public string? CardAcctNumber18 { get; set; }

    public string? CardAcctUse18 { get; set; }

    public string? CardAcctType19 { get; set; }

    public string? CardAcctNumber19 { get; set; }

    public string? CardAcctUse19 { get; set; }

    public string? CardAcctType20 { get; set; }

    public string? CardAcctNumber20 { get; set; }

    public string? CardAcctUse20 { get; set; }

    public DateTime CardLastPinChange { get; set; }

    public DateTime CardNextPinChange { get; set; }

    public decimal CardTnpLimit { get; set; }

    public decimal CardTnpUsed { get; set; }

    public byte CardTnpCountLimit { get; set; }

    public byte CardTnpCount { get; set; }
}
