using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace App.BP.Data.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChlCardBaseInfo> ChlCardBaseInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("M2D");

        modelBuilder.Entity<ChlCardBaseInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CHL_CARD_BASE_INFO");

            entity.Property(e => e.CardAcctCount)
                .HasPrecision(2)
                .HasColumnName("CARD_ACCT_COUNT");
            entity.Property(e => e.CardAcctNumber1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_1");
            entity.Property(e => e.CardAcctNumber10)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_10");
            entity.Property(e => e.CardAcctNumber11)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_11");
            entity.Property(e => e.CardAcctNumber12)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_12");
            entity.Property(e => e.CardAcctNumber13)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_13");
            entity.Property(e => e.CardAcctNumber14)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_14");
            entity.Property(e => e.CardAcctNumber15)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_15");
            entity.Property(e => e.CardAcctNumber16)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_16");
            entity.Property(e => e.CardAcctNumber17)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_17");
            entity.Property(e => e.CardAcctNumber18)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_18");
            entity.Property(e => e.CardAcctNumber19)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_19");
            entity.Property(e => e.CardAcctNumber2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_2");
            entity.Property(e => e.CardAcctNumber20)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_20");
            entity.Property(e => e.CardAcctNumber3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_3");
            entity.Property(e => e.CardAcctNumber4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_4");
            entity.Property(e => e.CardAcctNumber5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_5");
            entity.Property(e => e.CardAcctNumber6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_6");
            entity.Property(e => e.CardAcctNumber7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_7");
            entity.Property(e => e.CardAcctNumber8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_8");
            entity.Property(e => e.CardAcctNumber9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_NUMBER_9");
            entity.Property(e => e.CardAcctType1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_1");
            entity.Property(e => e.CardAcctType10)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_10");
            entity.Property(e => e.CardAcctType11)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_11");
            entity.Property(e => e.CardAcctType12)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_12");
            entity.Property(e => e.CardAcctType13)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_13");
            entity.Property(e => e.CardAcctType14)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_14");
            entity.Property(e => e.CardAcctType15)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_15");
            entity.Property(e => e.CardAcctType16)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_16");
            entity.Property(e => e.CardAcctType17)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_17");
            entity.Property(e => e.CardAcctType18)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_18");
            entity.Property(e => e.CardAcctType19)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_19");
            entity.Property(e => e.CardAcctType2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_2");
            entity.Property(e => e.CardAcctType20)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_20");
            entity.Property(e => e.CardAcctType3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_3");
            entity.Property(e => e.CardAcctType4)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_4");
            entity.Property(e => e.CardAcctType5)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_5");
            entity.Property(e => e.CardAcctType6)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_6");
            entity.Property(e => e.CardAcctType7)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_7");
            entity.Property(e => e.CardAcctType8)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_8");
            entity.Property(e => e.CardAcctType9)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_TYPE_9");
            entity.Property(e => e.CardAcctUse1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_1");
            entity.Property(e => e.CardAcctUse10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_10");
            entity.Property(e => e.CardAcctUse11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_11");
            entity.Property(e => e.CardAcctUse12)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_12");
            entity.Property(e => e.CardAcctUse13)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_13");
            entity.Property(e => e.CardAcctUse14)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_14");
            entity.Property(e => e.CardAcctUse15)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_15");
            entity.Property(e => e.CardAcctUse16)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_16");
            entity.Property(e => e.CardAcctUse17)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_17");
            entity.Property(e => e.CardAcctUse18)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_18");
            entity.Property(e => e.CardAcctUse19)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_19");
            entity.Property(e => e.CardAcctUse2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_2");
            entity.Property(e => e.CardAcctUse20)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_20");
            entity.Property(e => e.CardAcctUse3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_3");
            entity.Property(e => e.CardAcctUse4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_4");
            entity.Property(e => e.CardAcctUse5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_5");
            entity.Property(e => e.CardAcctUse6)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_6");
            entity.Property(e => e.CardAcctUse7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_7");
            entity.Property(e => e.CardAcctUse8)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_8");
            entity.Property(e => e.CardAcctUse9)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_ACCT_USE_9");
            entity.Property(e => e.CardCustomerCardName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CARD_CUSTOMER_CARD_NAME");
            entity.Property(e => e.CardDeliveryDate)
                .HasPrecision(6)
                .HasColumnName("CARD_DELIVERY_DATE");
            entity.Property(e => e.CardDeliveryOffice)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CARD_DELIVERY_OFFICE");
            entity.Property(e => e.CardExpirationDate)
                .HasColumnType("DATE")
                .HasColumnName("CARD_EXPIRATION_DATE");
            entity.Property(e => e.CardFirstUseDate)
                .HasPrecision(6)
                .HasColumnName("CARD_FIRST_USE_DATE");
            entity.Property(e => e.CardInstitution)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CARD_INSTITUTION");
            entity.Property(e => e.CardIssueDate)
                .HasPrecision(6)
                .HasColumnName("CARD_ISSUE_DATE");
            entity.Property(e => e.CardIssueOffice)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CARD_ISSUE_OFFICE");
            entity.Property(e => e.CardLastPinChange)
                .HasPrecision(6)
                .HasColumnName("CARD_LAST_PIN_CHANGE");
            entity.Property(e => e.CardLastStatusChange)
                .HasPrecision(6)
                .HasColumnName("CARD_LAST_STATUS_CHANGE");
            entity.Property(e => e.CardLastUseDate)
                .HasPrecision(6)
                .HasColumnName("CARD_LAST_USE_DATE");
            entity.Property(e => e.CardLimitResetPeriod)
                .HasPrecision(2)
                .HasColumnName("CARD_LIMIT_RESET_PERIOD");
            entity.Property(e => e.CardMandatoryPinChange)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CARD_MANDATORY_PIN_CHANGE");
            entity.Property(e => e.CardMobCount)
                .HasPrecision(2)
                .HasColumnName("CARD_MOB_COUNT");
            entity.Property(e => e.CardMobCountLimit)
                .HasPrecision(2)
                .HasColumnName("CARD_MOB_COUNT_LIMIT");
            entity.Property(e => e.CardMobLimit)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_MOB_LIMIT");
            entity.Property(e => e.CardMobUsed)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_MOB_USED");
            entity.Property(e => e.CardNetworkId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CARD_NETWORK_ID");
            entity.Property(e => e.CardNextPinChange)
                .HasPrecision(6)
                .HasColumnName("CARD_NEXT_PIN_CHANGE");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_NUMBER");
            entity.Property(e => e.CardOwnerId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_OWNER_ID");
            entity.Property(e => e.CardOwnerIdType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CARD_OWNER_ID_TYPE");
            entity.Property(e => e.CardPinFailCount)
                .HasPrecision(2)
                .HasColumnName("CARD_PIN_FAIL_COUNT");
            entity.Property(e => e.CardPinFailLimit)
                .HasPrecision(2)
                .HasColumnName("CARD_PIN_FAIL_LIMIT");
            entity.Property(e => e.CardPinOffset)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CARD_PIN_OFFSET");
            entity.Property(e => e.CardPosCount)
                .HasPrecision(2)
                .HasColumnName("CARD_POS_COUNT");
            entity.Property(e => e.CardPosCountLimit)
                .HasPrecision(2)
                .HasColumnName("CARD_POS_COUNT_LIMIT");
            entity.Property(e => e.CardPosLimit)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_POS_LIMIT");
            entity.Property(e => e.CardPosUsed)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_POS_USED");
            entity.Property(e => e.CardReissueDate)
                .HasPrecision(6)
                .HasColumnName("CARD_REISSUE_DATE");
            entity.Property(e => e.CardStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CARD_STATUS");
            entity.Property(e => e.CardTnpCount)
                .HasPrecision(2)
                .HasDefaultValueSql("0 ")
                .HasColumnName("CARD_TNP_COUNT");
            entity.Property(e => e.CardTnpCountLimit)
                .HasPrecision(2)
                .HasDefaultValueSql("0 ")
                .HasColumnName("CARD_TNP_COUNT_LIMIT");
            entity.Property(e => e.CardTnpLimit)
                .HasDefaultValueSql("0 ")
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_TNP_LIMIT");
            entity.Property(e => e.CardTnpUsed)
                .HasDefaultValueSql("0 ")
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_TNP_USED");
            entity.Property(e => e.CardType)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CARD_TYPE");
            entity.Property(e => e.CardWdCount)
                .HasPrecision(2)
                .HasColumnName("CARD_WD_COUNT");
            entity.Property(e => e.CardWdCountLimit)
                .HasPrecision(2)
                .HasColumnName("CARD_WD_COUNT_LIMIT");
            entity.Property(e => e.CardWdLimit)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_WD_LIMIT");
            entity.Property(e => e.CardWdUsed)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_WD_USED");
            entity.Property(e => e.CardXfrCount)
                .HasPrecision(2)
                .HasColumnName("CARD_XFR_COUNT");
            entity.Property(e => e.CardXfrCountLimit)
                .HasPrecision(2)
                .HasColumnName("CARD_XFR_COUNT_LIMIT");
            entity.Property(e => e.CardXfrLimit)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_XFR_LIMIT");
            entity.Property(e => e.CardXfrOthersLimit)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_XFR_OTHERS_LIMIT");
            entity.Property(e => e.CardXfrOthersUsed)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_XFR_OTHERS_USED");
            entity.Property(e => e.CardXfrUsed)
                .HasColumnType("NUMBER(12,2)")
                .HasColumnName("CARD_XFR_USED");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
