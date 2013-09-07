using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeExchangeMonitor
{
    class Defines
    {
        public enum ATSessionStatusType
        {
            SessionStatusDisconnected = 1,
            SessionStatusDisconnectedDuplicateLogin,
            SessionStatusConnected
        };

        public enum ATLoginResponseType
        {
            LoginResponseSuccess = 1,
            LoginResponseInvalidUserid,
            LoginResponseInvalidPassword,
            LoginResponseInvalidRequest,
            LoginResponseLoginDenied,
            LoginResponseServerError
        };

        public enum ATDataType
        {
            DataByte = 1,
            DataByteArray,
            DataUInteger32,
            DataUInteger64,
            DataInteger32,
            DataInteger64,
            DataPrice,
            DataString,
            DataUnicodeString,
            DataDateTime,
            DataDouble
        };

        public enum ATSymbolStatus
        {
            SymbolStatusSuccess = 1,
            SymbolStatusInvalid,
            SymbolStatusUnavailable,
            SymbolStatusNoPermission
        };

        public enum ATSymbolType
        {
            SymbolStock = 'S',
            SymbolIndex = 'I',
            SymbolStockOption = 'O',
            SymbolBond = 'B',
            SymbolMutualFund = 'M',
            SymbolTopMarketMovers = 'T',
            SymbolCurrency = 'C'
        };

        public enum ATOptionType
        {
            OptionTypeCall = 'C',
            OptionTypePut = 'P'
        };

        public enum ATExchangeType
        {
            ExchangeAMEX = 'A',
            ExchangeNasdaqOmxBx = 'B',
            ExchangeNationalStockExchange = 'C',
            ExchangeFinraAdf = 'D',
            ExchangeCQS = 'E',
            ExchangeForex = 'F',
            ExchangeInternationalSecuritiesExchange = 'I',
            ExchangeEdgaExchange = 'J',
            ExchangeEdgxExchange = 'K',
            ExchangeChicagoStockExchange = 'M',
            ExchangeNyseEuronext = 'N',
            ExchangeNyseArcaExchange = 'P',
            ExchangeNasdaqOmx = 'Q',
            ExchangeCTS = 'S',
            ExchangeCTANasdaqOMX = 'T',
            ExchangeOTCBB = 'U',
            ExchangeNNOTC = 'u',
            ExchangeChicagoBoardOptionsExchange = 'W',
            ExchangeNasdaqOmxPhlx = 'X',
            ExchangeBatsYExchange = 'Y',
            ExchangeBatsExchange = 'Z',
            ExchangeCanadaToronto = 'T',
            ExchangeCanadaVenture = 'V',
            ExchangeOpra = 'O',
            ExchangeOptionBoston = 'B',
            ExchangeOptionCboe = 'C',
            ExchangeOptionNyseArca = 'N',
            ExchangeOptionC2 = 'W',
            ExchangeOptionNasdaqOmxBx = 'T',
            ExchangeComposite = ' '
        };

        public enum ATCountryType
        {
            CountryInternational = 'I',
            CountryUnitedStates = 'U',
            CountryCanada = 'C'
        };

        public enum ATFieldStatus
        {
            FieldStatusSuccess = 1,
            FieldStatusInvalid,
            FieldStatusUnavailable,
            FieldStatusDenied
        };

        public enum ATQuoteFieldType
        {
            //Intraday fields
            QuoteFieldSymbol = 1,
            QuoteFieldOpenPrice,
            QuoteFieldPreviousClosePrice,
            QuoteFieldClosePrice,
            QuoteFieldLastPrice,
            QuoteFieldBidPrice,
            QuoteFieldAskPrice,
            QuoteFieldHighPrice,
            QuoteFieldLowPrice,
            QuoteFieldDayHighPrice,
            QuoteFieldDayLowPrice,
            QuoteFieldPreMarketOpenPrice,
            QuoteFieldExtendedHoursLastPrice,
            QuoteFieldAfterMarketClosePrice,
            QuoteFieldBidExchange,
            QuoteFieldAskExchange,
            QuoteFieldLastExchange,
            QuoteFieldLastCondition,
            QuoteFieldQuoteCondition,
            QuoteFieldLastTradeDateTime,
            QuoteFieldLastQuoteDateTime,
            QuoteFieldDayHighDateTime,
            QuoteFieldDayLowDateTime,
            QuoteFieldLastSize,
            QuoteFieldBidSize,
            QuoteFieldAskSize,
            QuoteFieldVolume,
            QuoteFieldPreMarketVolume,
            QuoteFieldAfterMarketVolume,
            QuoteFieldTradeCount,
            QuoteFieldPreMarketTradeCount,
            QuoteFieldAfterMarketTradeCount,

            //Profile fields
            QuoteFieldProfileShortName,
            QuoteFieldProfilePrimaryExchange,
            QuoteFieldProfileLongName,
            QuoteFieldProfileSector,
            QuoteFieldProfileIndustry,

            //Option fields
            QuoteFieldOptionOpenInterest = 100,
            QuoteFieldOptionStrikePrice,

            //Financials - Income statement fields
            QuoteFieldIncomeStatementBasicEPSFromContinuingOperations = 200,
            QuoteFieldIncomeStatementBasicEPSFromDiscontinuedOperations,
            QuoteFieldIncomeStatementBasicEPSFromTotalOperations,
            QuoteFieldIncomeStatementBasicEPSFromExtraordinaryIncome,
            QuoteFieldIncomeStatementBasicEPSFromCumEffectOfAccountingChange,
            QuoteFieldIncomeStatementBasicEPSFromOtherGains,
            QuoteFieldIncomeStatementBasicEPSTotal,
            QuoteFieldIncomeStatementBasicNormalizedNetIncomePerShare,
            QuoteFieldIncomeStatementDilutedEPSFromContinuingOperations,
            QuoteFieldIncomeStatementDilutedEPSFromDiscontinuedOperations,
            QuoteFieldIncomeStatementDilutedEPSFromTotalOperations,
            QuoteFieldIncomeStatementDilutedEPSFromExtraordinaryIncome,
            QuoteFieldIncomeStatementDilutedEPSFromOtherGains,
            QuoteFieldIncomeStatementDilutedEPSTotal,
            QuoteFieldIncomeStatementDilutedNormalizedNetIncomePerShare,
            QuoteFieldIncomeStatementDividendsPaidPerShare,
            QuoteFieldIncomeStatementIncomeAcquiredInProcessRD,
            QuoteFieldIncomeStatementOtherSpecialCharges,
            QuoteFieldIncomeStatementIncomeTaxes,
            QuoteFieldIncomeStatementMinorityInterest,
            QuoteFieldIncomeStatementNetIncomeFromContinuingOperations,
            QuoteFieldIncomeStatementNetIncomeFromDiscontinuedOperations,
            QuoteFieldIncomeStatementNetIncomeFromTotalOperations,
            QuoteFieldIncomeStatementIncomeFromTaxLossCarryforward,
            QuoteFieldIncomeStatementOtherGainsLosses,
            QuoteFieldIncomeStatementTotalNetIncome,
            QuoteFieldIncomeStatementNormalizedIncome,
            QuoteFieldIncomeStatementNetIncomeAvailableForCommon,
            QuoteFieldIncomeStatementPreferredDividends,
            QuoteFieldIncomeStatementStandardOperatingRevenue,
            QuoteFieldIncomeStatementStandardTotalRevenue,
            QuoteFieldIncomeStatementStandardAdjustmentToRevenue,
            QuoteFieldIncomeStatementStandardCostOfSales,
            QuoteFieldIncomeStatementStandardCostOfSalesWithDepreciation,
            QuoteFieldIncomeStatementStandardGrossMargin,
            QuoteFieldIncomeStatementStandardGrossOperatingProfit,
            QuoteFieldIncomeStatementStandardResearchAndDevelopment,
            QuoteFieldIncomeStatementStandardSellingGeneralAndAdminExpense,
            QuoteFieldIncomeStatementStandardAdvertising,
            QuoteFieldIncomeStatementStandardOperatingProfit,
            QuoteFieldIncomeStatementStandardOperatingProfitBeforeDepreciation,
            QuoteFieldIncomeStatementStandardDepreciation,
            QuoteFieldIncomeStatementStandardDepreciationUnreconciled,
            QuoteFieldIncomeStatementStandardAmortization,
            QuoteFieldIncomeStatementStandardAmortizationOfIntangibles,
            QuoteFieldIncomeStatementStandardOperatingIncomeAfterDepreciation,
            QuoteFieldIncomeStatementStandardInterestIncome,
            QuoteFieldIncomeStatementStandardEarningsFromEquityInterest,
            QuoteFieldIncomeStatementStandardOtherIncomeNet,
            QuoteFieldIncomeStatementStandardInterestRestructuringAndMA,
            QuoteFieldIncomeStatementStandardTotalIncomeAvailForInterestExpense,
            QuoteFieldIncomeStatementStandardInterestExpense,
            QuoteFieldIncomeStatementStandardIncomeBeforeTax,
            QuoteFieldIncomeStatementStandardPreferredSecuritiesOfSubsidiaryTrust,
            QuoteFieldIncomeStatementStandardExtraordinaryIncomeOrLosses,
            QuoteFieldIncomeStatementStandardIncomeFromCumEffectOfAccountChange,
            QuoteFieldIncomeStatementStandardExciseTaxes,
            QuoteFieldIncomeStatementFinancialLoans,
            QuoteFieldIncomeStatementFinancialInvestmentSecurities,
            QuoteFieldIncomeStatementFinancialLeaseFinancingIncome,
            QuoteFieldIncomeStatementFinancialOtherInterestIncome,
            QuoteFieldIncomeStatementFinancialFedFundsSoldPurchased,
            QuoteFieldIncomeStatementFinancialInterestBearingDeposits,
            QuoteFieldIncomeStatementFinancialLoansHeldForResale,
            QuoteFieldIncomeStatementFinancialTradingAccountSecurities,
            QuoteFieldIncomeStatementFinancialTimeDepositsPlaced,
            QuoteFieldIncomeStatementFinancialOtherMoneyMarketInvestments,
            QuoteFieldIncomeStatementFinancialTotalMoneyMarketInvestments,
            QuoteFieldIncomeStatementFinancialTotalInterestIncome,
            QuoteFieldIncomeStatementFinancialDeposits,
            QuoteFieldIncomeStatementFinancialFedFundsPurchasedSecSold,
            QuoteFieldIncomeStatementFinancialCapitalizedLeaseObligations,
            QuoteFieldIncomeStatementFinancialOtherInterestExpense,
            QuoteFieldIncomeStatementFinancialTotalInterestExpense,
            QuoteFieldIncomeStatementFinancialNetInterestIncomeExpense,
            QuoteFieldIncomeStatementFinancialProvisionForLoanLoss,
            QuoteFieldIncomeStatementFinancialTrustFeesByCommissions,
            QuoteFieldIncomeStatementFinancialServiceChargeOnDepositAccounts,
            QuoteFieldIncomeStatementFinancialOtherServiceCharges,
            QuoteFieldIncomeStatementFinancialSecurityTransactions,
            QuoteFieldIncomeStatementFinancialPremiumsEarned,
            QuoteFieldIncomeStatementFinancialNetRealizedCapitalGains,
            QuoteFieldIncomeStatementFinancialInvestmentBankingProfit,
            QuoteFieldIncomeStatementFinancialOtherNonInterestIncome,
            QuoteFieldIncomeStatementFinancialTotalNonInterestIncome,
            QuoteFieldIncomeStatementFinancialSalariesAndEmployeeBenefits,
            QuoteFieldIncomeStatementFinancialNetOccupancyExpense,
            QuoteFieldIncomeStatementFinancialPromotionsAndAdvertising,
            QuoteFieldIncomeStatementFinancialPropLiabInsuranceClaims,
            QuoteFieldIncomeStatementFinancialPolicyAcquisitionCosts,
            QuoteFieldIncomeStatementFinancialAmortDefPolicyAcqCost,
            QuoteFieldIncomeStatementFinancialCurrentAndFutureBenefits,
            QuoteFieldIncomeStatementFinancialOtherNonInterestExpense,
            QuoteFieldIncomeStatementFinancialTotalNonInterestExpense,
            QuoteFieldIncomeStatementFinancialPremiumTaxCredit,
            QuoteFieldIncomeStatementFinancialIncomeRestructuringAndMA,
            QuoteFieldIncomeStatementFinancialSpecialIncomeCharges,
            QuoteFieldIncomeStatementFinancialExtraordinaryIncomeLosses,
            QuoteFieldIncomeStatementFinancialIncomeFromCumEffectOfAcctChg,
            QuoteFieldIncomeStatementDate,

            //Financials - Balance sheets fields
            QuoteFieldBalanceSheetsAssetsRestrictedCash = 500,
            QuoteFieldBalanceSheetsAssetsOtherReceivable,
            QuoteFieldBalanceSheetsAssetsTotalAssets,
            QuoteFieldBalanceSheetsLiabilitiesShortTermDebt,
            QuoteFieldBalanceSheetsLiabilitiesLongTermDebt,
            QuoteFieldBalanceSheetsLiabilitiesCapitalLeaseObligations,
            QuoteFieldBalanceSheetsLiabilitiesMinorityInterest,
            QuoteFieldBalanceSheetsLiabilitiesTotalLiabilities,
            QuoteFieldBalanceSheetsShareDataSharesOutstandingCommonClassOnly,
            QuoteFieldBalanceSheetsShareDataPreferredShares,
            QuoteFieldBalanceSheetsShareDataTotalOrdinaryShares,
            QuoteFieldBalanceSheetsShareDataTotalCommonSharesOutstanding,
            QuoteFieldBalanceSheetsShareDataTreasuryShares,
            QuoteFieldBalanceSheetsEquityPreferredStockEquity,
            QuoteFieldBalanceSheetsEquityCommonStockEquity,
            QuoteFieldBalanceSheetsEquityCommonPar,
            QuoteFieldBalanceSheetsEquityAdditionalPaidInCapital,
            QuoteFieldBalanceSheetsEquityCumulativeTranslationAdjustment,
            QuoteFieldBalanceSheetsEquityRetainedEarnings,
            QuoteFieldBalanceSheetsEquityTreasuryStock,
            QuoteFieldBalanceSheetsEquityOtherEquityAdjustments,
            QuoteFieldBalanceSheetsEquityTotalEquity,
            QuoteFieldBalanceSheetsEquityTotalCapitalization,
            QuoteFieldBalanceSheetsEquityTotalLiabilitiesAndStockEquity,
            QuoteFieldBalanceSheetsNumberOfEmployees,
            QuoteFieldBalanceSheetsNumberOfPartTimeEmployees,
            QuoteFieldBalanceSheetsStandardAssetsCashAndEquivalents,
            QuoteFieldBalanceSheetsStandardAssetsMarketableSecurities,
            QuoteFieldBalanceSheetsStandardAssetsAccountsReceivable,
            QuoteFieldBalanceSheetsStandardAssetsLoansReceivable,
            QuoteFieldBalanceSheetsStandardAssetsReceivables,
            QuoteFieldBalanceSheetsStandardAssetsRawMaterials,
            QuoteFieldBalanceSheetsStandardAssetsWorkInProgress,
            QuoteFieldBalanceSheetsStandardAssetsPurchasedComponents,
            QuoteFieldBalanceSheetsStandardAssetsFinishedGoods,
            QuoteFieldBalanceSheetsStandardAssetsOtherInventories,
            QuoteFieldBalanceSheetsStandardAssetsInventoriesAdjAllowances,
            QuoteFieldBalanceSheetsStandardAssetsInventories,
            QuoteFieldBalanceSheetsStandardAssetsPrepaidExpenses,
            QuoteFieldBalanceSheetsStandardAssetsCurrentDeferredIncomeTaxes,
            QuoteFieldBalanceSheetsStandardAssetsOtherCurrentAssets,
            QuoteFieldBalanceSheetsStandardAssetsTotalCurrentAssets,
            QuoteFieldBalanceSheetsStandardAssetsGrossFixedAssets,
            QuoteFieldBalanceSheetsStandardAssetsAccumulatedDepreciationAndDepletion,
            QuoteFieldBalanceSheetsStandardAssetsNetFixedAssets,
            QuoteFieldBalanceSheetsStandardAssetsIntangibles,
            QuoteFieldBalanceSheetsStandardAssetsCostInExcess,
            QuoteFieldBalanceSheetsStandardAssetsNonCurrentDeferredIncomeTaxes,
            QuoteFieldBalanceSheetsStandardAssetsOtherNonCurrentAssets,
            QuoteFieldBalanceSheetsStandardAssetsTotalNonCurrentAssets,
            QuoteFieldBalanceSheetsStandardLiabilitiesAccountsPayable,
            QuoteFieldBalanceSheetsStandardLiabilitiesNotesPayable,
            QuoteFieldBalanceSheetsStandardLiabilitiesAccruedExpenses,
            QuoteFieldBalanceSheetsStandardLiabilitiesAccruedLiabilities,
            QuoteFieldBalanceSheetsStandardLiabilitiesDeferredRevenues,
            QuoteFieldBalanceSheetsStandardLiabilitiesCurrentDeferredIncomeTaxes,
            QuoteFieldBalanceSheetsStandardLiabilitiesOtherCurrentLiabilities,
            QuoteFieldBalanceSheetsStandardLiabilitiesTotalCurrentLiabilities,
            QuoteFieldBalanceSheetsStandardLiabilitiesDeferredIncomeTaxes,
            QuoteFieldBalanceSheetsStandardLiabilitiesOtherNonCurrentLiabilities,
            QuoteFieldBalanceSheetsStandardLiabilitiesPreferredSecuritiesOfSubsidiaryTrust,
            QuoteFieldBalanceSheetsStandardLiabilitiesPreferredEquityOutsideStockEquity,
            QuoteFieldBalanceSheetsStandardLiabilitiesTotalNonCurrentLiabilities,
            QuoteFieldBalanceSheetsStandardCashFlow,
            QuoteFieldBalanceSheetsStandardWorkingCapital,
            QuoteFieldBalanceSheetsStandardFreeCashFlow,
            QuoteFieldBalanceSheetsStandardInvestedCapital,
            QuoteFieldBalanceSheetsFinancialAssetsCashAndDueFromBanks,
            QuoteFieldBalanceSheetsFinancialAssetsFedFundsSoldSecuritiesPurchased,
            QuoteFieldBalanceSheetsFinancialAssetsInterestBearingDepAtOtherBanks,
            QuoteFieldBalanceSheetsFinancialAssetsInvestmentSecuritiesNet,
            QuoteFieldBalanceSheetsFinancialAssetsLoans,
            QuoteFieldBalanceSheetsFinancialAssetsUnearnedPremiums,
            QuoteFieldBalanceSheetsFinancialAssetsAllowanceForLoansAndLeaseLosses,
            QuoteFieldBalanceSheetsFinancialAssetsNetLoans,
            QuoteFieldBalanceSheetsFinancialAssetsPremisesAndEquipment,
            QuoteFieldBalanceSheetsFinancialAssetsDueFromCustomersAcceptance,
            QuoteFieldBalanceSheetsFinancialAssetsTradingAccountSecurities,
            QuoteFieldBalanceSheetsFinancialAssetsAccruedInterest,
            QuoteFieldBalanceSheetsFinancialAssetsDeferredAcquisitionCost,
            QuoteFieldBalanceSheetsFinancialAssetsAccruedInvestmentIncome,
            QuoteFieldBalanceSheetsFinancialAssetsSeparateAccountBusiness,
            QuoteFieldBalanceSheetsFinancialAssetsTimeDepositsPlaced,
            QuoteFieldBalanceSheetsFinancialAssetsIntangibleAssets,
            QuoteFieldBalanceSheetsFinancialAssetsOtherAssets,
            QuoteFieldBalanceSheetsFinancialLiabilitiesNonInterestBearingDeposits,
            QuoteFieldBalanceSheetsFinancialLiabilitiesInterestBearingDeposits,
            QuoteFieldBalanceSheetsFinancialLiabilitiesOtherLiabilities,
            QuoteFieldBalanceSheetsFinancialLiabilitiesBankersAcceptanceOutstanding,
            QuoteFieldBalanceSheetsFinancialLiabilitiesFedFundsPurchasedSecuritiesSold,
            QuoteFieldBalanceSheetsFinancialLiabilitiesAccruedTaxes,
            QuoteFieldBalanceSheetsFinancialLiabilitiesAccruedInterestPayables,
            QuoteFieldBalanceSheetsFinancialLiabilitiesOtherPayables,
            QuoteFieldBalanceSheetsFinancialLiabilitiesClaimsAndClaimExpense,
            QuoteFieldBalanceSheetsFinancialLiabilitiesFuturePolicyBenefits,
            QuoteFieldBalanceSheetsFinancialLiabilitiesUnearnedPremiums,
            QuoteFieldBalanceSheetsFinancialLiabilitiesPolicyHolderFunds,
            QuoteFieldBalanceSheetsFinancialLiabilitiesParticipatingPolicyholderEquity,
            QuoteFieldBalanceSheetsFinancialLiabilitiesSeparateAccountsBusiness,
            QuoteFieldBalanceSheetsFinancialEquityForeignCurrencyAdjustments,
            QuoteFieldBalanceSheetsFinancialEquityNetUnrealizedLossGainOnInvestments,
            QuoteFieldBalanceSheetsFinancialEquityNetUnrealizedLossGainOnForeignCurrency,
            QuoteFieldBalanceSheetsFinancialEquityNetOtherUnearnedLossesGains,
            QuoteFieldBalanceSheetsDate,

            //Financials - Cash flow fields
            QuoteFieldCashFlowOperatingActivitiesNetIncomeOrLoss = 800,
            QuoteFieldCashFlowOperatingActivitiesDeferredIncomeTaxes,
            QuoteFieldCashFlowOperatingActivitiesOtherNonCashItems,
            QuoteFieldCashFlowInvestingActivitiesAcquisitions,
            QuoteFieldCashFlowInvestingActivitiesOtherInvestingChangesNet,
            QuoteFieldCashFlowInvestingActivitiesNetCashFromInvestingActivities,
            QuoteFieldCashFlowFinancingActivitiesNetCashFromFinancingActivities,
            QuoteFieldCashFlowFinancingActivitiesEffectOfExchangeRateChanges,
            QuoteFieldCashFlowFinancingActivitiesCashAtBeginningOfPeriod,
            QuoteFieldCashFlowFinancingActivitiesCashAtEndOfPeriod,
            QuoteFieldCashFlowStandardOperatingActivitiesDepreciation,
            QuoteFieldCashFlowStandardOperatingActivitiesAmortization,
            QuoteFieldCashFlowStandardOperatingActivitiesAmortizationOfIntangibles,
            QuoteFieldCashFlowStandardOperatingActivitiesOperatingGainsOrLosses,
            QuoteFieldCashFlowStandardOperatingActivitiesExtraordinaryGainsOrLosses,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInReceivables,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInInventories,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInPrepaidExpenses,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInOtherCurrentAssets,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInPayables,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInOtherCurrLiabilities,
            QuoteFieldCashFlowStandardOperatingActivitiesIncreaseOrDecreaseInOtherWorkingCapital,
            QuoteFieldCashFlowStandardOperatingActivitiesNetCashFromContinuingOperations,
            QuoteFieldCashFlowStandardOperatingActivitiesNetCashFromDiscontinuedOperations,
            QuoteFieldCashFlowStandardOperatingActivitiesNetCashFromOperatingActivities,
            QuoteFieldCashFlowStandardInvestingActivitiesSaleOfPropertyPlantEquipment,
            QuoteFieldCashFlowStandardInvestingActivitiesSaleOfLongTermInvestments,
            QuoteFieldCashFlowStandardInvestingActivitiesSaleOfShortTermInvestments,
            QuoteFieldCashFlowStandardInvestingActivitiesPurchaseOfPropertyPlantEquipment,
            QuoteFieldCashFlowStandardInvestingActivitiesPurchaseOfLongTermInvestments,
            QuoteFieldCashFlowStandardInvestingActivitiesPurchaseOfShortTermInvestments,
            QuoteFieldCashFlowStandardInvestingActivitiesCashFromDiscInvestingActivities,
            QuoteFieldCashFlowStandardFinancingActivitiesIssuanceOfDebt,
            QuoteFieldCashFlowStandardFinancingActivitiesIssuanceOfCapitalStock,
            QuoteFieldCashFlowStandardFinancingActivitiesRepaymentOfDebt,
            QuoteFieldCashFlowStandardFinancingActivitiesRepurchaseOfCapitalStock,
            QuoteFieldCashFlowStandardFinancingActivitiesPaymentOfCashDividends,
            QuoteFieldCashFlowStandardFinancingActivitiesOtherFinancingChargesNet,
            QuoteFieldCashFlowStandardFinancingActivitiesCashFromDiscFinancingActivities,
            QuoteFieldCashFlowStandardFinancingActivitiesNetChangeInCashAndCashEquivalents,
            QuoteFieldCashFlowFinancialOperatingActivitiesProvisionForLoanLosses,
            QuoteFieldCashFlowFinancialOperatingActivitiesDepreciationandAmortization,
            QuoteFieldCashFlowFinancialOperatingActivitiesChangeInAssetsReceivables,
            QuoteFieldCashFlowFinancialOperatingActivitiesChangeInLiabilitiesPayables,
            QuoteFieldCashFlowFinancialOperatingActivitiesInvestmentSecuritiesGain,
            QuoteFieldCashFlowFinancialOperatingActivitiesNetPolicyAcquisitionCosts,
            QuoteFieldCashFlowFinancialOperatingActivitiesRealizedInvestmentGains,
            QuoteFieldCashFlowFinancialOperatingActivitiesNetPremiumsReceivables,
            QuoteFieldCashFlowFinancialOperatingActivitiesChangeInIncomeTaxes,
            QuoteFieldCashFlowFinancialOperatingActivitiesNetCashFromOperatingActivities,
            QuoteFieldCashFlowFinancialInvestingActivitiesProceedsFromSaleMatInv,
            QuoteFieldCashFlowFinancialInvestingActivitiesPurchaseOfInvestmentSecurities,
            QuoteFieldCashFlowFinancialInvestingActivitiesNetIncreaseFedFundsSold,
            QuoteFieldCashFlowFinancialInvestingActivitiesPurchaseOfPropertyAndEquipment,
            QuoteFieldCashFlowFinancialFinancingActivitiesNetChangeInDeposits,
            QuoteFieldCashFlowFinancialFinancingActivitiesCashDividendsPaid,
            QuoteFieldCashFlowFinancialFinancingActivitiesRepaymentOfLongTermDebt,
            QuoteFieldCashFlowFinancialFinancingActivitiesChangeOfShortTermDebt,
            QuoteFieldCashFlowFinancialFinancingActivitiesIssuanceOfLongTermDebt,
            QuoteFieldCashFlowFinancialFinancingActivitiesIssuanceOfPreferredStock,
            QuoteFieldCashFlowFinancialFinancingActivitiesIssuanceOfCommonStock,
            QuoteFieldCashFlowFinancialFinancingActivitiesPurchaseOfTreasuryStock,
            QuoteFieldCashFlowFinancialFinancingActivitiesOtherFinancingActivities,
            QuoteFieldCashFlowFinancialFinancingActivitiesNetChangeInCashAndEquivalents,
            QuoteFieldCashFlowDate
        };

        public enum ATQuoteDbResponseType
        {
            QuoteDbResponseSuccess = 1,
            QuoteDbResponseInvalidRequest,
            QuoteDbResponseDenied
        };

        public enum ATStreamRequestType
        {
            StreamRequestSubscribe = 1,
            StreamRequestUnsubscribe,
            StreamRequestSubscribeQuotesOnly,
            StreamRequestUnsubscribeQuotesOnly,
            StreamRequestSubscribeTradesOnly,
            StreamRequestUnsubscribeTradesOnly
        };

        public enum ATStreamResponseType
        {
            StreamResponseSuccess = 1,
            StreamResponseInvalidRequest,
            StreamResponseDenied
        };

        public enum ATBarHistoryType
        {
            BarHistoryIntraday,
            BarHistoryDaily,
            BarHistoryWeekly
        };

        public enum ATBarHistoryResponseType
        {
            BarHistoryResponseSuccess = 1,
            BarHistoryResponseInvalidRequest,
            BarHistoryResponseMaxLimitReached,
            BarHistoryResponseDenied
        };

        public enum ATTickHistoryRecordType
        {
            TickHistoryRecordTrade = 1,
            TickHistoryRecordQuote
        };

        public enum ATTickHistoryResponseType
        {
            TickHistoryResponseSuccess = 1,
            TickHistoryResponseInvalidRequest,
            TickHistoryResponseMaxLimitReached,
            TickHistoryResponseDenied
        };

        public enum ATTradeConditionType
        {
            TradeConditionRegular,
            TradeConditionAcquisition,
            TradeConditionAveragePrice,
            TradeConditionAutomaticExecution,
            TradeConditionBunched,
            TradeConditionBunchSold,
            TradeConditionCAPElection,
            TradeConditionCash,
            TradeConditionClosing,
            TradeConditionCross,
            TradeConditionDerivativelyPriced,
            TradeConditionDistribution,
            TradeConditionFormT,
            TradeConditionFormTOutOfSequence,
            TradeConditionInterMarketSweep,
            TradeConditionMarketCenterOfficialClose,
            TradeConditionMarketCenterOfficialOpen,
            TradeConditionMarketCenterOpening,
            TradeConditionMarketCenterReOpenning,
            TradeConditionMarketCenterClosing,
            TradeConditionNextDay,
            TradeConditionPriceVariation,
            TradeConditionPriorReferencePrice,
            TradeConditionRule155Amex,
            TradeConditionRule127Nyse,
            TradeConditionOpening,
            TradeConditionOpened,
            TradeConditionRegularStoppedStock,
            TradeConditionReOpening,
            TradeConditionSeller,
            TradeConditionSoldLast,
            TradeConditionSoldLastStoppedStock,
            TradeConditionSoldOutOfSequence,
            TradeConditionSoldOutOfSequenceStoppedStock,
            TradeConditionSplit,
            TradeConditionStockOption,
            TradeConditionYellowFlag
        };

        public enum ATQuoteConditionType
        {
            QuoteConditionRegular,
            QuoteConditionRegularTwoSidedOpen,
            QuoteConditionRegularOneSidedOpen,
            QuoteConditionSlowAsk,
            QuoteConditionSlowBid,
            QuoteConditionSlowBidAsk,
            QuoteConditionSlowDueLRPBid,
            QuoteConditionSlowDueLRPAsk,
            QuoteConditionSlowDueNYSELRP,
            QuoteConditionSlowDueSetSlowListBidAsk,
            QuoteConditionManualAskAutomaticBid,
            QuoteConditionManualBidAutomaticAsk,
            QuoteConditionManualBidAndAsk,
            QuoteConditionOpening,
            QuoteConditionClosing,
            QuoteConditionClosed,
            QuoteConditionResume,
            QuoteConditionFastTrading,
            QuoteConditionTradingRangeIndication,
            QuoteConditionMarketMakerQuotesClosed,
            QuoteConditionNonFirm,
            QuoteConditionNewsDissemination,
            QuoteConditionOrderInflux,
            QuoteConditionOrderImbalance,
            QuoteConditionDueToRelatedSecurityNewsDissemination,
            QuoteConditionDueToRelatedSecurityNewsPending,
            QuoteConditionAdditionalInformation,
            QuoteConditionNewsPending,
            QuoteConditionAdditionalInformationDueToRelatedSecurity,
            QuoteConditionDueToRelatedSecurity,
            QuoteConditionInViewOfCommon,
            QuoteConditionEquipmentChangeover,
            QuoteConditionNoOpenNoResume,
            QuoteConditionSubPennyTrading,
            QuoteConditionAutomatedBidNoOfferNoBid
        };

        public enum ATTradeMessageFlags
        {
            TradeMessageFlagRegularMarketLastPrice = 0x1,
            TradeMessageFlagRegularMarketVolume = 0x2,

            TradeMessageFlagHighPrice = 0x4,
            TradeMessageFlagLowPrice = 0x8,
            TradeMessageFlagDayHighPrice = 0x10,
            TradeMessageFlagDayLowPrice = 0x20,

            TradeMessageFlagExtendedMarketLastPrice = 0x40,
            TradeMessageFlagPreMarketVolume = 0x80,
            TradeMessageFlagAfterMarketVolume = 0x100,
            TradeMessageFlagPreMarketOpenPrice = 0x200,
            TradeMessageFlagOpenPrice = 0x400
        };

        public enum ATConstituentListType
        {
            ATConstituentListIndex = 1,
            ATConstituentListSector,
            ATConstituentListOptionChain
        };

    }
}
