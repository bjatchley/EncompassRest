using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class StateDisclosure
    {
        public JsonNullable<bool?> AcceptedByBorrowerIndicator { get; set; }
        public JsonNullable<DateTime?> AcceptedDate { get; set; }
        public string ActingOtherDescription1 { get; set; }
        public string ActingOtherDescription2 { get; set; }
        public JsonNullable<bool?> ActingOthersIndicator { get; set; }
        public JsonNullable<int?> AdvFeeAgmtInEfctNumDay { get; set; }
        public string AdvisoryCondition1 { get; set; }
        public string AdvisoryCondition2 { get; set; }
        public string AdvisoryCondition3 { get; set; }
        public string AdvisoryCondition4 { get; set; }
        public JsonNullable<decimal?> AmendedAcquisitionCost { get; set; }
        public JsonNullable<DateTime?> ApplicationDate { get; set; }
        public string AppraisalContact { get; set; }
        public JsonNullable<decimal?> AppraisalDeposit { get; set; }
        public string Areas { get; set; }
        public JsonNullable<bool?> AsAttorneyIndicator { get; set; }
        public JsonNullable<bool?> AsRealBrokerIndicator { get; set; }
        public JsonNullable<bool?> AttorneyForTheBuyerIndicator { get; set; }
        public JsonNullable<bool?> AttorneyForTheLenderIndicator { get; set; }
        public JsonNullable<bool?> AttorneyForTheSellerIndicator { get; set; }
        public string AZCmplBlankSpcsDoc1BlankFldDesc1 { get; set; }
        public string AZCmplBlankSpcsDoc1BlankFldDesc2 { get; set; }
        public string AZCmplBlankSpcsDoc1BlankFldDesc3 { get; set; }
        public string AZCmplBlankSpcsDoc1Nm { get; set; }
        public string AZCmplBlankSpcsDoc2Nm { get; set; }
        public string AZCmplBlankSpcsDoc3Nm { get; set; }
        public string BasedOnOthersDescription { get; set; }
        public JsonNullable<bool?> BasedOnOthersIndicator { get; set; }
        public JsonNullable<bool?> BasedOnWholesaleOptionsIndicator { get; set; }
        public JsonNullable<decimal?> BorrowerElectsEstablishEscrowAmount { get; set; }
        public JsonNullable<bool?> BorrowerElectsEstablishEscrowIndicator { get; set; }
        public JsonNullable<decimal?> BrokerageFeeAddition1 { get; set; }
        public JsonNullable<decimal?> BrokerageFeeAddition2 { get; set; }
        public JsonNullable<decimal?> BrokerageFeeAddition3 { get; set; }
        public JsonNullable<decimal?> BrokerageFeeAmount1 { get; set; }
        public JsonNullable<decimal?> BrokerageFeeAmount2 { get; set; }
        public JsonNullable<decimal?> BrokerageFeeAmount3 { get; set; }
        public JsonNullable<int?> BrokerageFeeDays { get; set; }
        public JsonNullable<decimal?> BrokerageFeePercent1 { get; set; }
        public JsonNullable<decimal?> BrokerageFeePercent2 { get; set; }
        public JsonNullable<decimal?> BrokerageFeePercent3 { get; set; }
        public string BrokerAuthorizedSigningRepName { get; set; }
        public string BrokerAuthorizedSigningRepTitle { get; set; }
        public string BrokerForTheSeller { get; set; }
        public string BrokerLicense { get; set; }
        public string BrokerName { get; set; }
        public JsonNullable<decimal?> BrokerPayAddition { get; set; }
        public JsonNullable<decimal?> BrokerPayAmount { get; set; }
        public JsonNullable<bool?> BrokerPayIndicator { get; set; }
        public JsonNullable<decimal?> BrokerPayPercent { get; set; }
        public JsonNullable<bool?> CHARMBookletIndicator { get; set; }
        public string CheckPayableTo { get; set; }
        public JsonNullable<decimal?> CommitmentAmount { get; set; }
        public string CommitmentCondition1 { get; set; }
        public string CommitmentCondition2 { get; set; }
        public JsonNullable<decimal?> CommitmentFee { get; set; }
        public JsonNullable<decimal?> CommitmentPercent { get; set; }
        public JsonNullable<decimal?> CompensationAddition { get; set; }
        public JsonNullable<decimal?> CompensationPercent { get; set; }
        public JsonNullable<decimal?> CreditDeposit { get; set; }
        public string CreditIsUsedForReason { get; set; }
        public string CreditReportContact { get; set; }
        public JsonNullable<int?> DaysBeforeClosing { get; set; }
        public JsonNullable<decimal?> DepositReceipt { get; set; }
        public JsonNullable<bool?> DepositRefundableIndicator { get; set; }
        public string DirectContact { get; set; }
        public JsonNullable<decimal?> DirectPayAmount { get; set; }
        public JsonNullable<decimal?> DirectPayClosing { get; set; }
        public JsonNullable<decimal?> DirectPayCommitment { get; set; }
        public JsonNullable<bool?> DirectPayIndicator { get; set; }
        public JsonNullable<decimal?> DirectPayPercent { get; set; }
        public string DisclosureDeliveredBy { get; set; }
        public string DisclosureDeliveredByOtherMethod { get; set; }
        public JsonNullable<DateTime?> DisclosureDeliveredDate { get; set; }
        public JsonNullable<bool?> EstimatedChargeShownOnGFEIndicator { get; set; }
        public JsonNullable<DateTime?> ExpirationDate { get; set; }
        public JsonNullable<decimal?> FederallySubsidizedAmount { get; set; }
        public JsonNullable<decimal?> FederallySubsidizedAmountPercentage { get; set; }
        public JsonNullable<decimal?> FeeReceived1 { get; set; }
        public JsonNullable<decimal?> FeeReceived2 { get; set; }
        public string FeeReceivedByLender { get; set; }
        public JsonNullable<decimal?> FeesReceiving { get; set; }
        public JsonNullable<decimal?> FloridaApplicationFee { get; set; }
        public JsonNullable<decimal?> FloridaOtherFee1 { get; set; }
        public JsonNullable<decimal?> FloridaOtherFee2 { get; set; }
        public string FloridaOtherFeeTo1 { get; set; }
        public string FloridaOtherFeeTo2 { get; set; }
        public string FloridaOtherFeeTo3 { get; set; }
        public string FloridaOtherFeeTo4 { get; set; }
        public string FurtherFeesEarnedByMortgageBroker { get; set; }
        public JsonNullable<decimal?> GFEFeeReceived1 { get; set; }
        public JsonNullable<decimal?> GFEFeeReceived2 { get; set; }
        public JsonNullable<bool?> HUDBookletIndicator { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IndependentContractorIndicator { get; set; }
        public string IndexUsed { get; set; }
        public string InformationAboutTheIndexCanBeFound { get; set; }
        public string InLicensedNo { get; set; }
        public string InLicensedType { get; set; }
        public JsonNullable<bool?> IsEstimateIndicator { get; set; }
        public JsonNullable<bool?> KsUcccElectionIndicator { get; set; }
        public JsonNullable<bool?> KyHomeSolicationLoanIndicator { get; set; }
        public JsonNullable<DateTime?> LeaseAgreementDate { get; set; }
        public JsonNullable<DateTime?> LenderDate { get; set; }
        public string LenderName { get; set; }
        public JsonNullable<decimal?> LenderPaid { get; set; }
        public JsonNullable<decimal?> LenderPayAmount { get; set; }
        public JsonNullable<bool?> LenderPayIndicator { get; set; }
        public JsonNullable<decimal?> LenderPayMaxPoint { get; set; }
        public JsonNullable<decimal?> LenderPayPercent { get; set; }
        public JsonNullable<decimal?> LenderPayPoint { get; set; }
        public JsonNullable<bool?> LenderPayUnknownIndicator { get; set; }
        public string LenderStatus { get; set; }
        public string LessorName { get; set; }
        public JsonNullable<bool?> LoanTermsFixedThroughDateofLoanClosingIndicator { get; set; }
        public JsonNullable<decimal?> LockInFee { get; set; }
        public string MethodDescription { get; set; }
        public string MethodDetermine { get; set; }
        public JsonNullable<bool?> MortgageAgreementIndicator { get; set; }
        public string MtgBrokerLicense { get; set; }
        public string NameOfLicensee { get; set; }
        public JsonNullable<decimal?> NewMoneyAmount { get; set; }
        public JsonNullable<decimal?> NewYorkApplicationFee { get; set; }
        public JsonNullable<decimal?> NewYorkAppraisalFee { get; set; }
        public JsonNullable<decimal?> NewYorkCreditReportFee { get; set; }
        public JsonNullable<List<NewYorkFee>> NewYorkFees { get; set; }
        public JsonNullable<List<NewYorkPrimaryLender>> NewYorkPrimaryLenders { get; set; }
        public JsonNullable<decimal?> NewYorkProcessingFee { get; set; }
        public JsonNullable<decimal?> NotRefundableAmount { get; set; }
        public JsonNullable<bool?> OfferRetailPriceIndicator { get; set; }
        public JsonNullable<decimal?> OriginalAcquisitionCost { get; set; }
        public JsonNullable<decimal?> OriginationFeeChargedAmount { get; set; }
        public JsonNullable<bool?> OriginationFeeChargedIndicator { get; set; }
        public JsonNullable<decimal?> OriginationFeeDecreasesRate { get; set; }
        public JsonNullable<decimal?> OriginationFeeIncreasesRate { get; set; }
        public string OriginationFeeInterestRateImpactedStatus { get; set; }
        public string OriginationFeePaidBy { get; set; }
        public JsonNullable<decimal?> PaidByBorrower { get; set; }
        public JsonNullable<decimal?> PaidByLender { get; set; }
        public JsonNullable<decimal?> PaidByOther1 { get; set; }
        public JsonNullable<decimal?> PaidByOther2 { get; set; }
        public string PaidByOtherDescription1 { get; set; }
        public string PaidByOtherDescription2 { get; set; }
        public JsonNullable<decimal?> PreviousMortgageAmountOne { get; set; }
        public JsonNullable<decimal?> PreviousMortgageAmountTwo { get; set; }
        public JsonNullable<bool?> PrintCertificationOfCosts { get; set; }
        public JsonNullable<bool?> PrintInterestRateReductionRider { get; set; }
        public JsonNullable<bool?> PrintMDDeliveryIndicator { get; set; }
        public string ProvidedBy { get; set; }
        public string QuestionContact { get; set; }
        public string QuestionContactPhone { get; set; }
        public string QuestionContactTollFree { get; set; }
        public JsonNullable<bool?> RateLockHonoredIndicator { get; set; }
        public string ReceivedBy { get; set; }
        public JsonNullable<decimal?> RefinancingFee { get; set; }
        public string RefundableBy { get; set; }
        public JsonNullable<bool?> RefundableIndicator { get; set; }
        public string RefundableType { get; set; }
        public string RefundCondition1 { get; set; }
        public string RefundCondition2 { get; set; }
        public string RefundCondition3 { get; set; }
        public string RefundCondition4 { get; set; }
        public string RefundCondition5 { get; set; }
        public string RefundCondition6 { get; set; }
        public string RegulatorAddress { get; set; }
        public string RegulatorCity { get; set; }
        public string RegulatorMailingAddress { get; set; }
        public string RegulatorMailingCity { get; set; }
        public string RegulatorMailingState { get; set; }
        public string RegulatorMailingZipCode { get; set; }
        public string RegulatorPhone { get; set; }
        public string RegulatorState { get; set; }
        public string RegulatorTollFreePhone { get; set; }
        public string RegulatorWebAddress { get; set; }
        public string RegulatorZipCode { get; set; }
        public string ScheduleOfChargesEstimatedFinalIndicator { get; set; }
        public string ScRegulatoryAgencyType { get; set; }
        public JsonNullable<bool?> SelectDivisionFeesIndicator { get; set; }
        public JsonNullable<bool?> SelectPrimaryLenderIndicator { get; set; }
        public JsonNullable<bool?> SelectPrivateLenderIndicator { get; set; }
        public JsonNullable<decimal?> ServicingFeeChargedAmount { get; set; }
        public JsonNullable<bool?> ServicingFeeChargedIndicator { get; set; }
        public string ServicingFeePaidBy { get; set; }
        public string ServicingFeePaidFrequence { get; set; }
        public JsonNullable<bool?> SignedByBorrowerIndicator { get; set; }
        public JsonNullable<bool?> SpecificARMIndicator { get; set; }
        public JsonNullable<bool?> SubmitToLenderIndicator { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationAssessments { get; set; }
        public string TaxExemptAcquisitionCostCertificationOther { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationOtherAmount { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationRealEstateCommission { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationRepairsImprovements { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationSurvey { get; set; }
        public JsonNullable<decimal?> TaxExemptAcquisitionCostCertificationTotalAdjustments { get; set; }
        public string TermsChange { get; set; }
        public JsonNullable<decimal?> TexasApplicationFee { get; set; }
        public JsonNullable<decimal?> TexasAppraisalFee { get; set; }
        public JsonNullable<decimal?> TexasCreditReportFee { get; set; }
        public JsonNullable<decimal?> TexasOtherFee1 { get; set; }
        public JsonNullable<decimal?> TexasOtherFee2 { get; set; }
        public string TexasOtherFeeContact1 { get; set; }
        public string TexasOtherFeeContact2 { get; set; }
        public JsonNullable<decimal?> TexasProcessingFee { get; set; }
        public JsonNullable<decimal?> ThirdPartyFee { get; set; }
        public JsonNullable<decimal?> TotalFee { get; set; }
        public JsonNullable<decimal?> TransferFeeChargedAmount { get; set; }
        public JsonNullable<bool?> TransferFeeChargedIndicator { get; set; }
        public string TransferFeePaidBy { get; set; }
        public JsonNullable<bool?> TxVeteransLandBoardIndicator { get; set; }
        public string TypeOfProperty { get; set; }
        public string UnderwritingContact { get; set; }
        public JsonNullable<decimal?> UnderwritingFee { get; set; }
        public JsonNullable<decimal?> YSPChargedAmount { get; set; }
        public JsonNullable<bool?> YSPChargedIndicator { get; set; }
        public JsonNullable<decimal?> YSPDecreasesRate { get; set; }
        public JsonNullable<decimal?> YSPIncreasesRate { get; set; }
        public string YSPInterestRateImpactedStatus { get; set; }
        public string YSPPaidBy { get; set; }
    }
}