using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Test.Models.Mapping;

namespace Test.Models
{
    public partial class V3_DataTOPContext : DbContext
    {
        static V3_DataTOPContext()
        {
            Database.SetInitializer<V3_DataTOPContext>(null);
        }

        public V3_DataTOPContext()
            : base("Name=V3_DataTOPContext")
        {
        }

        public DbSet<Ac_Account> Ac_Account { get; set; }
        public DbSet<Ac_Account_Assist_CheckItems> Ac_Account_Assist_CheckItems { get; set; }
        public DbSet<Ac_Account_Set_Detail> Ac_Account_Set_Detail { get; set; }
        public DbSet<Ac_Account_Set_List> Ac_Account_Set_List { get; set; }
        public DbSet<Ac_AccountsPeroid_Stype> Ac_AccountsPeroid_Stype { get; set; }
        public DbSet<Ac_AssetBusinessType> Ac_AssetBusinessType { get; set; }
        public DbSet<Ac_AssetsCards> Ac_AssetsCards { get; set; }
        public DbSet<Ac_AssetsCards_History> Ac_AssetsCards_History { get; set; }
        public DbSet<Ac_AssetsCategory> Ac_AssetsCategory { get; set; }
        public DbSet<Ac_AssetsModifyRecords> Ac_AssetsModifyRecords { get; set; }
        public DbSet<Ac_AssetStorageLocation> Ac_AssetStorageLocation { get; set; }
        public DbSet<Ac_AssetWorkingCondition> Ac_AssetWorkingCondition { get; set; }
        public DbSet<Ac_Assist_CheckItems> Ac_Assist_CheckItems { get; set; }
        public DbSet<Ac_Assist_CheckItems_BillType> Ac_Assist_CheckItems_BillType { get; set; }
        public DbSet<Ac_Assist_CheckItemsDetail> Ac_Assist_CheckItemsDetail { get; set; }
        public DbSet<Ac_Auditing_Template> Ac_Auditing_Template { get; set; }
        public DbSet<Ac_Auditing_Template_Detail> Ac_Auditing_Template_Detail { get; set; }
        public DbSet<Ac_Auditing_Template_SummaryFiled> Ac_Auditing_Template_SummaryFiled { get; set; }
        public DbSet<Ac_Balance_Assist_CheckItems> Ac_Balance_Assist_CheckItems { get; set; }
        public DbSet<Ac_Balance_Assist_CheckItems_Detail> Ac_Balance_Assist_CheckItems_Detail { get; set; }
        public DbSet<Ac_BalanceType> Ac_BalanceType { get; set; }
        public DbSet<Ac_Bank> Ac_Bank { get; set; }
        public DbSet<Ac_Batch_Bills_Result> Ac_Batch_Bills_Result { get; set; }
        public DbSet<Ac_BillMoney_List> Ac_BillMoney_List { get; set; }
        public DbSet<Ac_CashMoneyItems> Ac_CashMoneyItems { get; set; }
        public DbSet<Ac_CommissionBill_VoucherBill> Ac_CommissionBill_VoucherBill { get; set; }
        public DbSet<Ac_Currency> Ac_Currency { get; set; }
        public DbSet<Ac_DepreciationAlteration> Ac_DepreciationAlteration { get; set; }
        public DbSet<Ac_DepreciationPlan> Ac_DepreciationPlan { get; set; }
        public DbSet<Ac_Expenses> Ac_Expenses { get; set; }
        public DbSet<Ac_FixedAssets> Ac_FixedAssets { get; set; }
        public DbSet<Ac_FixedAssetsInit_Stype> Ac_FixedAssetsInit_Stype { get; set; }
        public DbSet<Ac_GoodsBill_VoucherBill> Ac_GoodsBill_VoucherBill { get; set; }
        public DbSet<Ac_IniAccount> Ac_IniAccount { get; set; }
        public DbSet<Ac_IniAccount_Assist_CheckItems> Ac_IniAccount_Assist_CheckItems { get; set; }
        public DbSet<Ac_IniAccount_Assist_CheckItems_Detail> Ac_IniAccount_Assist_CheckItems_Detail { get; set; }
        public DbSet<Ac_Items> Ac_Items { get; set; }
        public DbSet<Ac_Items_Detail> Ac_Items_Detail { get; set; }
        public DbSet<Ac_MulColumnAccount> Ac_MulColumnAccount { get; set; }
        public DbSet<Ac_MulColumnAccount_Assist> Ac_MulColumnAccount_Assist { get; set; }
        public DbSet<Ac_OtherGains> Ac_OtherGains { get; set; }
        public DbSet<Ac_Period> Ac_Period { get; set; }
        public DbSet<Ac_ProfitAndLoss> Ac_ProfitAndLoss { get; set; }
        public DbSet<Ac_ProfitAndLoss_Detail> Ac_ProfitAndLoss_Detail { get; set; }
        public DbSet<Ac_Provision_Voucher> Ac_Provision_Voucher { get; set; }
        public DbSet<Ac_ProvisionForImpairment> Ac_ProvisionForImpairment { get; set; }
        public DbSet<Ac_ReceiptBill_VoucherBill> Ac_ReceiptBill_VoucherBill { get; set; }
        public DbSet<Ac_SubsidiaryEquipment> Ac_SubsidiaryEquipment { get; set; }
        public DbSet<Ac_Table> Ac_Table { get; set; }
        public DbSet<Ac_Voucher> Ac_Voucher { get; set; }
        public DbSet<Ac_Voucher_Bill> Ac_Voucher_Bill { get; set; }
        public DbSet<Ac_Voucher_Bill_Assist_CheckItems> Ac_Voucher_Bill_Assist_CheckItems { get; set; }
        public DbSet<Ac_Voucher_Bill_CashMoneyItems> Ac_Voucher_Bill_CashMoneyItems { get; set; }
        public DbSet<Ac_Voucher_Bill_Temp> Ac_Voucher_Bill_Temp { get; set; }
        public DbSet<Ac_Voucher_Commonly> Ac_Voucher_Commonly { get; set; }
        public DbSet<Ac_Voucher_Commonly_Bill> Ac_Voucher_Commonly_Bill { get; set; }
        public DbSet<Ac_Voucher_Generate_Voucherbill_GoodsBills> Ac_Voucher_Generate_Voucherbill_GoodsBills { get; set; }
        public DbSet<Ac_Voucher_Group> Ac_Voucher_Group { get; set; }
        public DbSet<Ac_Voucher_Group_Detail> Ac_Voucher_Group_Detail { get; set; }
        public DbSet<Ac_Voucher_Repair_Msg> Ac_Voucher_Repair_Msg { get; set; }
        public DbSet<Ac_Voucher_Temp> Ac_Voucher_Temp { get; set; }
        public DbSet<Ac_VoucherCommonly_Bill_Assist_CheckItems> Ac_VoucherCommonly_Bill_Assist_CheckItems { get; set; }
        public DbSet<AccountCredence> AccountCredences { get; set; }
        public DbSet<AccountInterFaceFileList> AccountInterFaceFileLists { get; set; }
        public DbSet<AccountSubjectSet> AccountSubjectSets { get; set; }
        public DbSet<AccountTimeConfig> AccountTimeConfigs { get; set; }
        public DbSet<AdDebtBill> AdDebtBills { get; set; }
        public DbSet<AddPrintCountRecord> AddPrintCountRecords { get; set; }
        public DbSet<AdPriceBill> AdPriceBills { get; set; }
        public DbSet<Advantage> Advantages { get; set; }
        public DbSet<Advantage_standard> Advantage_standard { get; set; }
        public DbSet<AppraisalBackBill> AppraisalBackBills { get; set; }
        public DbSet<AppraisalBill> AppraisalBills { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaType> AreaTypes { get; set; }
        public DbSet<Areatype_CustomColumns> Areatype_CustomColumns { get; set; }
        public DbSet<AskPriceBill> AskPriceBills { get; set; }
        public DbSet<AssetIncDecBill> AssetIncDecBills { get; set; }
        public DbSet<AttendanceLimit> AttendanceLimits { get; set; }
        public DbSet<AttendanceTime> AttendanceTimes { get; set; }
        public DbSet<atype> atypes { get; set; }
        public DbSet<atype_l> atype_l { get; set; }
        public DbSet<AType_Total> AType_Total { get; set; }
        public DbSet<AuditingBill> AuditingBills { get; set; }
        public DbSet<AuditingBillDetail> AuditingBillDetails { get; set; }
        public DbSet<AuditingFlowDetail> AuditingFlowDetails { get; set; }
        public DbSet<AuditingFlowSet> AuditingFlowSets { get; set; }
        public DbSet<AuditingReason> AuditingReasons { get; set; }
        public DbSet<AuditingRelation> AuditingRelations { get; set; }
        public DbSet<AuditingStepReason> AuditingStepReasons { get; set; }
        public DbSet<AutoType> AutoTypes { get; set; }
        public DbSet<BalanceFile> BalanceFiles { get; set; }
        public DbSet<Bank_l> Bank_l { get; set; }
        public DbSet<BarCode> BarCodes { get; set; }
        public DbSet<BarCode_Ext> BarCode_Ext { get; set; }
        public DbSet<BarCode_Source> BarCode_Source { get; set; }
        public DbSet<BarCodeForBilltype> BarCodeForBilltypes { get; set; }
        public DbSet<BaseInfoAssitDetection> BaseInfoAssitDetections { get; set; }
        public DbSet<BatchPrice> BatchPrices { get; set; }
        public DbSet<BATypeIdPreset> BATypeIdPresets { get; set; }
        public DbSet<BBS_catalog> BBS_catalog { get; set; }
        public DbSet<BBS_luntan> BBS_luntan { get; set; }
        public DbSet<BBS_userinformation> BBS_userinformation { get; set; }
        public DbSet<BBSUpFile> BBSUpFiles { get; set; }
        public DbSet<BeforePromoteIndex> BeforePromoteIndexes { get; set; }
        public DbSet<BeforePromoteRetailBill> BeforePromoteRetailBills { get; set; }
        public DbSet<BeforePromoteSaleBill> BeforePromoteSaleBills { get; set; }
        public DbSet<BillAttachFile> BillAttachFiles { get; set; }
        public DbSet<BillAttachFilesLog> BillAttachFilesLogs { get; set; }
        public DbSet<BillAtype> BillAtypes { get; set; }
        public DbSet<BillCode_Seed> BillCode_Seed { get; set; }
        public DbSet<BillHeadControlField> BillHeadControlFields { get; set; }
        public DbSet<BillIndex> BillIndexes { get; set; }
        public DbSet<Billindex_CarRepair> Billindex_CarRepair { get; set; }
        public DbSet<BillMulAccount> BillMulAccounts { get; set; }
        public DbSet<BillName> BillNames { get; set; }
        public DbSet<BillOperateLog> BillOperateLogs { get; set; }
        public DbSet<BillPrintConfig> BillPrintConfigs { get; set; }
        public DbSet<BillSaveTimeLog> BillSaveTimeLogs { get; set; }
        public DbSet<btype> btypes { get; set; }
        public DbSet<BType_ArApTotal> BType_ArApTotal { get; set; }
        public DbSet<Btype_CustomColumns> Btype_CustomColumns { get; set; }
        public DbSet<btype_l> btype_l { get; set; }
        public DbSet<BType_Picture> BType_Picture { get; set; }
        public DbSet<BtypePriceInfo> BtypePriceInfoes { get; set; }
        public DbSet<BuyBackBill> BuyBackBills { get; set; }
        public DbSet<BuyBill> BuyBills { get; set; }
        public DbSet<BuyGoodsExchangeBill> BuyGoodsExchangeBills { get; set; }
        public DbSet<CapitalTransfer_Bill> CapitalTransfer_Bill { get; set; }
        public DbSet<CargoType> CargoTypes { get; set; }
        public DbSet<CarriageUnit> CarriageUnits { get; set; }
        public DbSet<CashMoneyBill> CashMoneyBills { get; set; }
        public DbSet<ChargeOffBill> ChargeOffBills { get; set; }
        public DbSet<Chat_action> Chat_action { get; set; }
        public DbSet<Chat_autoact> Chat_autoact { get; set; }
        public DbSet<Chat_desc> Chat_desc { get; set; }
        public DbSet<Chat_guestbook> Chat_guestbook { get; set; }
        public DbSet<Chat_helpbody> Chat_helpbody { get; set; }
        public DbSet<Chat_ip_lock> Chat_ip_lock { get; set; }
        public DbSet<Chat_record> Chat_record { get; set; }
        public DbSet<Chat_room> Chat_room { get; set; }
        public DbSet<Chat_user> Chat_user { get; set; }
        public DbSet<Chat_vote> Chat_vote { get; set; }
        public DbSet<Chat_vrecord> Chat_vrecord { get; set; }
        public DbSet<CheckBIllData> CheckBIllDatas { get; set; }
        public DbSet<city> cities { get; set; }
        public DbSet<CM_CarInfo> CM_CarInfo { get; set; }
        public DbSet<CM_CarUseBill> CM_CarUseBill { get; set; }
        public DbSet<CM_CarUseIndex> CM_CarUseIndex { get; set; }
        public DbSet<CM_FeeBill> CM_FeeBill { get; set; }
        public DbSet<CM_FeeIndex> CM_FeeIndex { get; set; }
        public DbSet<CM_FeeType> CM_FeeType { get; set; }
        public DbSet<CodeConfig> CodeConfigs { get; set; }
        public DbSet<ColumnsField> ColumnsFields { get; set; }
        public DbSet<CommissionBill> CommissionBills { get; set; }
        public DbSet<CommissionBillNew> CommissionBillNews { get; set; }
        public DbSet<CommissionBillNewDetail> CommissionBillNewDetails { get; set; }
        public DbSet<CommissionRule> CommissionRules { get; set; }
        public DbSet<CommissionRuleEtype> CommissionRuleEtypes { get; set; }
        public DbSet<CommissionRuleLeader> CommissionRuleLeaders { get; set; }
        public DbSet<CommissionRulePtype> CommissionRulePtypes { get; set; }
        public DbSet<CommissionRuleRegion> CommissionRuleRegions { get; set; }
        public DbSet<CommissionScheme> CommissionSchemes { get; set; }
        public DbSet<CommissionSchemeStype> CommissionSchemeStypes { get; set; }
        public DbSet<CommissionType> CommissionTypes { get; set; }
        public DbSet<CommonPosInfo> CommonPosInfoes { get; set; }
        public DbSet<CommonPosPtypeCheckList> CommonPosPtypeCheckLists { get; set; }
        public DbSet<CommonPosPtypeCheckNdx> CommonPosPtypeCheckNdxes { get; set; }
        public DbSet<CommonPosSaleIndex> CommonPosSaleIndexes { get; set; }
        public DbSet<CommonPosSaleIndexFreeze> CommonPosSaleIndexFreezes { get; set; }
        public DbSet<CommonPosSaleIndexFreezeTemp> CommonPosSaleIndexFreezeTemps { get; set; }
        public DbSet<CommonPosSaleIndexTemp> CommonPosSaleIndexTemps { get; set; }
        public DbSet<CommonPosSaleList> CommonPosSaleLists { get; set; }
        public DbSet<CommonPosSaleListFreeze> CommonPosSaleListFreezes { get; set; }
        public DbSet<CommonPosSaleListFreezeTemp> CommonPosSaleListFreezeTemps { get; set; }
        public DbSet<CommonPosSaleListTemp> CommonPosSaleListTemps { get; set; }
        public DbSet<CompleteGoodTotal> CompleteGoodTotals { get; set; }
        public DbSet<CompleteTotal> CompleteTotals { get; set; }
        public DbSet<Cost_NoRelog> Cost_NoRelog { get; set; }
        public DbSet<CostRe_Bill> CostRe_Bill { get; set; }
        public DbSet<CostReLog> CostReLogs { get; set; }
        public DbSet<CPCX_catalog> CPCX_catalog { get; set; }
        public DbSet<CPCX_luntan> CPCX_luntan { get; set; }
        public DbSet<crm_btype> crm_btype { get; set; }
        public DbSet<CRM_BtypeShared> CRM_BtypeShared { get; set; }
        public DbSet<crm_linkman> crm_linkman { get; set; }
        public DbSet<CRM_LinkManShared> CRM_LinkManShared { get; set; }
        public DbSet<Crm_Message> Crm_Message { get; set; }
        public DbSet<Crm_MessageNoRead> Crm_MessageNoRead { get; set; }
        public DbSet<Crm_Schedule> Crm_Schedule { get; set; }
        public DbSet<Crm_Schedule_Etype> Crm_Schedule_Etype { get; set; }
        public DbSet<Custom_Column> Custom_Column { get; set; }
        public DbSet<Custom_Column_BillDetail> Custom_Column_BillDetail { get; set; }
        public DbSet<Custom_ColumnType> Custom_ColumnType { get; set; }
        public DbSet<Custom_DisplayColumn> Custom_DisplayColumn { get; set; }
        public DbSet<Custom_DisplayColumnOrder> Custom_DisplayColumnOrder { get; set; }
        public DbSet<CustomBillColumn> CustomBillColumns { get; set; }
        public DbSet<CustomBillDetailColumn> CustomBillDetailColumns { get; set; }
        public DbSet<customchangelog> customchangelogs { get; set; }
        public DbSet<CustomFieldData> CustomFieldDatas { get; set; }
        public DbSet<customPtypeItem> customPtypeItems { get; set; }
        public DbSet<CustomReference> CustomReferences { get; set; }
        public DbSet<CustomReferenceValue> CustomReferenceValues { get; set; }
        public DbSet<CX_CombinationBill> CX_CombinationBill { get; set; }
        public DbSet<CX_CombinationDetailBill> CX_CombinationDetailBill { get; set; }
        public DbSet<CX_LargessBill> CX_LargessBill { get; set; }
        public DbSet<CX_SaleByHand> CX_SaleByHand { get; set; }
        public DbSet<CX_SalePlanIndex> CX_SalePlanIndex { get; set; }
        public DbSet<CX_SaleStocksArea> CX_SaleStocksArea { get; set; }
        public DbSet<CX_SpecialOfferBill> CX_SpecialOfferBill { get; set; }
        public DbSet<DbConfig> DbConfigs { get; set; }
        public DbSet<DefaultStock> DefaultStocks { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepBill> DepBills { get; set; }
        public DbSet<DepPlanBill> DepPlanBills { get; set; }
        public DbSet<DepPlanIndex> DepPlanIndexes { get; set; }
        public DbSet<DisassembleBill> DisassembleBills { get; set; }
        public DbSet<distributingshowformat> distributingshowformats { get; set; }
        public DbSet<DiyBill> DiyBills { get; set; }
        public DbSet<DiyBillTypePSaleTypeID> DiyBillTypePSaleTypeIDs { get; set; }
        public DbSet<DiyIndex> DiyIndexes { get; set; }
        public DbSet<DiyType> DiyTypes { get; set; }
        public DbSet<DiyTypePTypeID> DiyTypePTypeIDs { get; set; }
        public DbSet<DocFile> DocFiles { get; set; }
        public DbSet<DocFilePath> DocFilePaths { get; set; }
        public DbSet<Dtype_CustomColumns> Dtype_CustomColumns { get; set; }
        public DbSet<dtype_l> dtype_l { get; set; }
        public DbSet<DtypeSaleAllPlan> DtypeSaleAllPlans { get; set; }
        public DbSet<DtypeSaleplan> DtypeSaleplans { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<EshopBaseInfo> EshopBaseInfoes { get; set; }
        public DbSet<EshopBillRelation> EshopBillRelations { get; set; }
        public DbSet<EshopGoodsInfo> EshopGoodsInfoes { get; set; }
        public DbSet<Etype_CustomColumns> Etype_CustomColumns { get; set; }
        public DbSet<etype_l> etype_l { get; set; }
        public DbSet<EType_Picture> EType_Picture { get; set; }
        public DbSet<EtypeCommissionType> EtypeCommissionTypes { get; set; }
        public DbSet<EtypeMacAndIP> EtypeMacAndIPs { get; set; }
        public DbSet<EtypeSaleAllPlan> EtypeSaleAllPlans { get; set; }
        public DbSet<EtypeSaleplan> EtypeSaleplans { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
        public DbSet<Expression> Expressions { get; set; }
        public DbSet<FaPiaoBill> FaPiaoBills { get; set; }
        public DbSet<FaPiaoBillIndex> FaPiaoBillIndexes { get; set; }
        public DbSet<fb_a> fb_a { get; set; }
        public DbSet<FixedAssetsDetail> FixedAssetsDetails { get; set; }
        public DbSet<FixedAssetsIndex> FixedAssetsIndexes { get; set; }
        public DbSet<frtype> frtypes { get; set; }
        public DbSet<FZ_Color> FZ_Color { get; set; }
        public DbSet<FZ_ColorGroup> FZ_ColorGroup { get; set; }
        public DbSet<FZ_CurColorSize> FZ_CurColorSize { get; set; }
        public DbSet<FZ_InitColorSize> FZ_InitColorSize { get; set; }
        public DbSet<FZ_InOutColorSize> FZ_InOutColorSize { get; set; }
        public DbSet<FZ_Size> FZ_Size { get; set; }
        public DbSet<FZ_SizeGroup> FZ_SizeGroup { get; set; }
        public DbSet<FZ_SizeMatching> FZ_SizeMatching { get; set; }
        public DbSet<gatheringBill> gatheringBills { get; set; }
        public DbSet<GBtype_CustomColumns> GBtype_CustomColumns { get; set; }
        public DbSet<GDSETCODE> GDSETCODEs { get; set; }
        public DbSet<GiveBill> GiveBills { get; set; }
        public DbSet<GiveFromSaleOrBuy> GiveFromSaleOrBuys { get; set; }
        public DbSet<GiveFromSaleOrBuyBill> GiveFromSaleOrBuyBills { get; set; }
        public DbSet<GivemeBill> GivemeBills { get; set; }
        public DbSet<GoodsExchangeBill> GoodsExchangeBills { get; set; }
        public DbSet<GoodsLocal> GoodsLocals { get; set; }
        public DbSet<GOODSSTOCKS_QTY> GOODSSTOCKS_QTY { get; set; }
        public DbSet<gp_CruPtypeSerial> gp_CruPtypeSerial { get; set; }
        public DbSet<gp_initLendPtypeSerial> gp_initLendPtypeSerial { get; set; }
        public DbSet<gp_initPtypeSerial> gp_initPtypeSerial { get; set; }
        public DbSet<gp_inoutPtypeSerial> gp_inoutPtypeSerial { get; set; }
        public DbSet<gp_LendPtypeSerial> gp_LendPtypeSerial { get; set; }
        public DbSet<GuestBack> GuestBacks { get; set; }
        public DbSet<GuestBackIndex> GuestBackIndexes { get; set; }
        public DbSet<GuestGet> GuestGets { get; set; }
        public DbSet<GuestGetIndex> GuestGetIndexes { get; set; }
        public DbSet<GuestPay> GuestPays { get; set; }
        public DbSet<GuestPayIndex> GuestPayIndexes { get; set; }
        public DbSet<Hotlist> Hotlists { get; set; }
        public DbSet<HR_Department> HR_Department { get; set; }
        public DbSet<HR_Img> HR_Img { get; set; }
        public DbSet<HR_InterviewDirection> HR_InterviewDirection { get; set; }
        public DbSet<HR_InterviewerEstimate> HR_InterviewerEstimate { get; set; }
        public DbSet<HR_NextEstimateTimes> HR_NextEstimateTimes { get; set; }
        public DbSet<HR_Person> HR_Person { get; set; }
        public DbSet<HR_PersonEdu> HR_PersonEdu { get; set; }
        public DbSet<HR_PersonFamily> HR_PersonFamily { get; set; }
        public DbSet<HR_PersonLimit> HR_PersonLimit { get; set; }
        public DbSet<HR_PersonStatus> HR_PersonStatus { get; set; }
        public DbSet<HR_PersonWorkExp> HR_PersonWorkExp { get; set; }
        public DbSet<HR_Postion> HR_Postion { get; set; }
        public DbSet<HR_Task> HR_Task { get; set; }
        public DbSet<HR_TaskDistribution> HR_TaskDistribution { get; set; }
        public DbSet<HR_TaskEstimate> HR_TaskEstimate { get; set; }
        public DbSet<HR_TaskStatus> HR_TaskStatus { get; set; }
        public DbSet<IM_Message> IM_Message { get; set; }
        public DbSet<IM_Message_NoSocket> IM_Message_NoSocket { get; set; }
        public DbSet<ImportPriceTemp> ImportPriceTemps { get; set; }
        public DbSet<ImportPtypeTemp> ImportPtypeTemps { get; set; }
        public DbSet<ImportPtypeTemp1> ImportPtypeTemp1 { get; set; }
        public DbSet<ImportState> ImportStates { get; set; }
        public DbSet<IndexChartData> IndexChartDatas { get; set; }
        public DbSet<Ini_GOODSSTOCKS_QTY> Ini_GOODSSTOCKS_QTY { get; set; }
        public DbSet<IniBType_ArApTotal> IniBType_ArApTotal { get; set; }
        public DbSet<IniCommissionStock> IniCommissionStocks { get; set; }
        public DbSet<IniStockAgeGroup> IniStockAgeGroups { get; set; }
        public DbSet<IniStockAgeStock> IniStockAgeStocks { get; set; }
        public DbSet<IniStockAgeStype> IniStockAgeStypes { get; set; }
        public DbSet<InitSaleSeralIndex> InitSaleSeralIndexes { get; set; }
        public DbSet<initSaleSerialbill> initSaleSerialbills { get; set; }
        public DbSet<InOutstocktable> InOutstocktables { get; set; }
        public DbSet<IntegralExchangeBill> IntegralExchangeBills { get; set; }
        public DbSet<IntercourseSetting> IntercourseSettings { get; set; }
        public DbSet<InvoiceBill> InvoiceBills { get; set; }
        public DbSet<IsStartOk> IsStartOks { get; set; }
        public DbSet<ItemATypeIdPreset> ItemATypeIdPresets { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemType_Item> ItemType_Item { get; set; }
        public DbSet<KinOutStockConfig> KinOutStockConfigs { get; set; }
        public DbSet<Ktype_CustomColumns> Ktype_CustomColumns { get; set; }
        public DbSet<ktype_l> ktype_l { get; set; }
        public DbSet<LeaveReason> LeaveReasons { get; set; }
        public DbSet<LendBill> LendBills { get; set; }
        public DbSet<LendIndex> LendIndexes { get; set; }
        public DbSet<ListTable> ListTables { get; set; }
        public DbSet<LocalDetail> LocalDetails { get; set; }
        public DbSet<LocalIndex> LocalIndexes { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<LoginManageInfo> LoginManageInfoes { get; set; }
        public DbSet<loginuser> loginusers { get; set; }
        public DbSet<LoginUserCol> LoginUserCols { get; set; }
        public DbSet<LoseBill> LoseBills { get; set; }
        public DbSet<LType> LTypes { get; set; }
        public DbSet<ManageBType> ManageBTypes { get; set; }
        public DbSet<ManualRegist> ManualRegists { get; set; }
        public DbSet<MenuTemplateConfig> MenuTemplateConfigs { get; set; }
        public DbSet<ModifyLog_AppraisalBackBill> ModifyLog_AppraisalBackBill { get; set; }
        public DbSet<ModifyLog_AppraisalBill> ModifyLog_AppraisalBill { get; set; }
        public DbSet<ModifyLog_BillIndex> ModifyLog_BillIndex { get; set; }
        public DbSet<ModifyLog_BuyBackBill> ModifyLog_BuyBackBill { get; set; }
        public DbSet<ModifyLog_BuyBill> ModifyLog_BuyBill { get; set; }
        public DbSet<ModifyLog_CompleteGoodTotal> ModifyLog_CompleteGoodTotal { get; set; }
        public DbSet<ModifyLog_CompleteTotal> ModifyLog_CompleteTotal { get; set; }
        public DbSet<ModifyLog_GatheringBill> ModifyLog_GatheringBill { get; set; }
        public DbSet<ModifyLog_PayBill> ModifyLog_PayBill { get; set; }
        public DbSet<ModifyLog_PreBill> ModifyLog_PreBill { get; set; }
        public DbSet<ModifyLog_ReceiptBill> ModifyLog_ReceiptBill { get; set; }
        public DbSet<ModifyLog_ReceiptBillIndex> ModifyLog_ReceiptBillIndex { get; set; }
        public DbSet<ModifyLog_SaleBackBill> ModifyLog_SaleBackBill { get; set; }
        public DbSet<ModifyLog_SaleBill> ModifyLog_SaleBill { get; set; }
        public DbSet<ModifyLog_SendBackBill> ModifyLog_SendBackBill { get; set; }
        public DbSet<ModifyLog_SendBill> ModifyLog_SendBill { get; set; }
        public DbSet<MoneyBill> MoneyBills { get; set; }
        public DbSet<MonthATypeHistory> MonthATypeHistories { get; set; }
        public DbSet<MonthProc> MonthProcs { get; set; }
        public DbSet<MoveBill> MoveBills { get; set; }
        public DbSet<MoveBjBill> MoveBjBills { get; set; }
        public DbSet<MoveMoneyBill> MoveMoneyBills { get; set; }
        public DbSet<Msg_MessageList> Msg_MessageList { get; set; }
        public DbSet<Msg_Online> Msg_Online { get; set; }
        public DbSet<news> news { get; set; }
        public DbSet<news_catalog> news_catalog { get; set; }
        public DbSet<NotePad> NotePads { get; set; }
        public DbSet<nVipAddMoney> nVipAddMoneys { get; set; }
        public DbSet<nVipAdjust> nVipAdjusts { get; set; }
        public DbSet<nVipCardSet> nVipCardSets { get; set; }
        public DbSet<NVipCardSetLog> NVipCardSetLogs { get; set; }
        public DbSet<nVipCardSign> nVipCardSigns { get; set; }
        public DbSet<nVipCardTypeChange> nVipCardTypeChanges { get; set; }
        public DbSet<nVipGoodsSign> nVipGoodsSigns { get; set; }
        public DbSet<nVipJfRule> nVipJfRules { get; set; }
        public DbSet<nVipJfSet> nVipJfSets { get; set; }
        public DbSet<OA_ASP_Dispatch> OA_ASP_Dispatch { get; set; }
        public DbSet<OA_Attachment> OA_Attachment { get; set; }
        public DbSet<OA_Catalog> OA_Catalog { get; set; }
        public DbSet<OA_Message> OA_Message { get; set; }
        public DbSet<OA_Message_Bak> OA_Message_Bak { get; set; }
        public DbSet<OA_OnlineUser> OA_OnlineUser { get; set; }
        public DbSet<OA_PersonalDesktop> OA_PersonalDesktop { get; set; }
        public DbSet<OA_PersonalMsgNotify_AND> OA_PersonalMsgNotify_AND { get; set; }
        public DbSet<OA_PersonalMsgNotify_OR> OA_PersonalMsgNotify_OR { get; set; }
        public DbSet<OA_PrivateDB> OA_PrivateDB { get; set; }
        public DbSet<OA_Product> OA_Product { get; set; }
        public DbSet<OA_PublicDB> OA_PublicDB { get; set; }
        public DbSet<OA_Right> OA_Right { get; set; }
        public DbSet<OA_RightTemplateDetail> OA_RightTemplateDetail { get; set; }
        public DbSet<OA_RightTemplateType> OA_RightTemplateType { get; set; }
        public DbSet<OA_Subscibe> OA_Subscibe { get; set; }
        public DbSet<OA_UserInformation> OA_UserInformation { get; set; }
        public DbSet<OA_Vote_EmployeeVoteInfo> OA_Vote_EmployeeVoteInfo { get; set; }
        public DbSet<OFF_Ftype> OFF_Ftype { get; set; }
        public DbSet<OFF_Right> OFF_Right { get; set; }
        public DbSet<Offline_Bill> Offline_Bill { get; set; }
        public DbSet<Offline_BillIndex> Offline_BillIndex { get; set; }
        public DbSet<OFFLINE_TASK> OFFLINE_TASK { get; set; }
        public DbSet<OftenComment> OftenComments { get; set; }
        public DbSet<OftenExplain> OftenExplains { get; set; }
        public DbSet<OftenMenu> OftenMenus { get; set; }
        public DbSet<Old_Bill> Old_Bill { get; set; }
        public DbSet<Old_BillMulAccount> Old_BillMulAccount { get; set; }
        public DbSet<Old_CompleteGoodTotal> Old_CompleteGoodTotal { get; set; }
        public DbSet<Old_CompleteTotal> Old_CompleteTotal { get; set; }
        public DbSet<Old_GatheringBill> Old_GatheringBill { get; set; }
        public DbSet<Old_Listtable> Old_Listtable { get; set; }
        public DbSet<Old_PayBill> Old_PayBill { get; set; }
        public DbSet<Old_PreBill> Old_PreBill { get; set; }
        public DbSet<OM_BackBillCodeSeed> OM_BackBillCodeSeed { get; set; }
        public DbSet<OM_BackCart> OM_BackCart { get; set; }
        public DbSet<OM_BackOrder> OM_BackOrder { get; set; }
        public DbSet<OM_BackOrderDetail> OM_BackOrderDetail { get; set; }
        public DbSet<OM_BillCodeSeed> OM_BillCodeSeed { get; set; }
        public DbSet<OM_BillIndex> OM_BillIndex { get; set; }
        public DbSet<OM_Carts> OM_Carts { get; set; }
        public DbSet<OM_DeliveryAddress> OM_DeliveryAddress { get; set; }
        public DbSet<OM_DiscountBill> OM_DiscountBill { get; set; }
        public DbSet<OM_Inventory> OM_Inventory { get; set; }
        public DbSet<OM_Inventory_Ext> OM_Inventory_Ext { get; set; }
        public DbSet<OM_InvoceBill> OM_InvoceBill { get; set; }
        public DbSet<OM_LoginUserLeveal> OM_LoginUserLeveal { get; set; }
        public DbSet<OM_LoginUsers> OM_LoginUsers { get; set; }
        public DbSet<OM_Order> OM_Order { get; set; }
        public DbSet<OM_OrderDetail> OM_OrderDetail { get; set; }
        public DbSet<OM_OrderDetails> OM_OrderDetails { get; set; }
        public DbSet<OM_Ptype> OM_Ptype { get; set; }
        public DbSet<OM_Ptype_l> OM_Ptype_l { get; set; }
        public DbSet<OM_PtypeClass> OM_PtypeClass { get; set; }
        public DbSet<OM_QuestionReply> OM_QuestionReply { get; set; }
        public DbSet<OM_ReplacementGoods> OM_ReplacementGoods { get; set; }
        public DbSet<OM_ReturnGoods> OM_ReturnGoods { get; set; }
        public DbSet<OM_Shipments> OM_Shipments { get; set; }
        public DbSet<OM_ShoppingCart> OM_ShoppingCart { get; set; }
        public DbSet<OM_SqlLog> OM_SqlLog { get; set; }
        public DbSet<OMBillAttachFile> OMBillAttachFiles { get; set; }
        public DbSet<OMBillCode_Seed> OMBillCode_Seed { get; set; }
        public DbSet<OMBillShipment> OMBillShipments { get; set; }
        public DbSet<Ord_AssemblyInfo> Ord_AssemblyInfo { get; set; }
        public DbSet<Ord_LimitList> Ord_LimitList { get; set; }
        public DbSet<Ord_Plug> Ord_Plug { get; set; }
        public DbSet<Ord_PlugInstallLog> Ord_PlugInstallLog { get; set; }
        public DbSet<Ord_PlugLimitFooting> Ord_PlugLimitFooting { get; set; }
        public DbSet<Ord_PopUpPage> Ord_PopUpPage { get; set; }
        public DbSet<OrderBill> OrderBills { get; set; }
        public DbSet<OrderFiledSchemeDetail> OrderFiledSchemeDetails { get; set; }
        public DbSet<OrderIndex> OrderIndexes { get; set; }
        public DbSet<OtherInOutBill> OtherInOutBills { get; set; }
        public DbSet<OtherInOutType> OtherInOutTypes { get; set; }
        public DbSet<overflowBill> overflowBills { get; set; }
        public DbSet<PayBill> PayBills { get; set; }
        public DbSet<PerformanceDistribution> PerformanceDistributions { get; set; }
        public DbSet<PloyType> PloyTypes { get; set; }
        public DbSet<Plug_EventLog> Plug_EventLog { get; set; }
        public DbSet<Plug_UserGroup> Plug_UserGroup { get; set; }
        public DbSet<Pos_AdvertisementPic> Pos_AdvertisementPic { get; set; }
        public DbSet<Pos_PicUpdateRecord> Pos_PicUpdateRecord { get; set; }
        public DbSet<Pos_UploadDogInfo> Pos_UploadDogInfo { get; set; }
        public DbSet<Pos_UploadPicRecord> Pos_UploadPicRecord { get; set; }
        public DbSet<POSBankRateInfo> POSBankRateInfoes { get; set; }
        public DbSet<PosCommonSysData> PosCommonSysDatas { get; set; }
        public DbSet<PosDataUpdated> PosDataUpdateds { get; set; }
        public DbSet<PosInfo> PosInfoes { get; set; }
        public DbSet<PosIsUpdateData> PosIsUpdateDatas { get; set; }
        public DbSet<PosMulAccount> PosMulAccounts { get; set; }
        public DbSet<PosMulAccountAll> PosMulAccountAlls { get; set; }
        public DbSet<PosRetailCash> PosRetailCashes { get; set; }
        public DbSet<PosRetailRecord> PosRetailRecords { get; set; }
        public DbSet<PosSaleBill> PosSaleBills { get; set; }
        public DbSet<PosSaleBillAll> PosSaleBillAlls { get; set; }
        public DbSet<PosSaleBillIndex> PosSaleBillIndexes { get; set; }
        public DbSet<PosSaleMergeFailed> PosSaleMergeFaileds { get; set; }
        public DbSet<PosVipMoneyList> PosVipMoneyLists { get; set; }
        public DbSet<PreBill> PreBills { get; set; }
        public DbSet<PriceBillIndex> PriceBillIndexes { get; set; }
        public DbSet<PriceBillIndex_Stype> PriceBillIndex_Stype { get; set; }
        public DbSet<PriceDetail> PriceDetails { get; set; }
        public DbSet<PriceDetailDeleted> PriceDetailDeleteds { get; set; }
        public DbSet<PriceProtect> PriceProtects { get; set; }
        public DbSet<PriceProtectBill> PriceProtectBills { get; set; }
        public DbSet<PriceRule> PriceRules { get; set; }
        public DbSet<PriceRule_Detail_BConfig> PriceRule_Detail_BConfig { get; set; }
        public DbSet<PriceRule_Detail_DConfig> PriceRule_Detail_DConfig { get; set; }
        public DbSet<PriceRule_Detail_EConfig> PriceRule_Detail_EConfig { get; set; }
        public DbSet<PriceRule_Detail_KConfig> PriceRule_Detail_KConfig { get; set; }
        public DbSet<PriceRule_Detail_StoresConfig> PriceRule_Detail_StoresConfig { get; set; }
        public DbSet<PriceRule_Detail_VipConfig> PriceRule_Detail_VipConfig { get; set; }
        public DbSet<PriceRule_Stype> PriceRule_Stype { get; set; }
        public DbSet<PriceRulePriority> PriceRulePriorities { get; set; }
        public DbSet<PriceTrack> PriceTracks { get; set; }
        public DbSet<PriceTrack_Appraisal> PriceTrack_Appraisal { get; set; }
        public DbSet<PriceTrack_Send> PriceTrack_Send { get; set; }
        public DbSet<PriceTrack_SType_Appraisal> PriceTrack_SType_Appraisal { get; set; }
        public DbSet<PriceTrack_SType_AskPrice> PriceTrack_SType_AskPrice { get; set; }
        public DbSet<PriceTrack_SType_Buy> PriceTrack_SType_Buy { get; set; }
        public DbSet<PriceTrack_SType_BuyOrder> PriceTrack_SType_BuyOrder { get; set; }
        public DbSet<PriceTrack_SType_Quote> PriceTrack_SType_Quote { get; set; }
        public DbSet<PriceTrack_SType_Sale> PriceTrack_SType_Sale { get; set; }
        public DbSet<PriceTrack_SType_SaleOrder> PriceTrack_SType_SaleOrder { get; set; }
        public DbSet<PriceTrack_SType_Send> PriceTrack_SType_Send { get; set; }
        public DbSet<PriceTrack_STypeMove> PriceTrack_STypeMove { get; set; }
        public DbSet<PrintRecord> PrintRecords { get; set; }
        public DbSet<ProduceModel> ProduceModels { get; set; }
        public DbSet<ProduceModelIndex> ProduceModelIndexes { get; set; }
        public DbSet<PromoRule> PromoRules { get; set; }
        public DbSet<PromoRule_Detail_BtypeConfig> PromoRule_Detail_BtypeConfig { get; set; }
        public DbSet<PromoRule_Detail_EConfig> PromoRule_Detail_EConfig { get; set; }
        public DbSet<PromoRule_Detail_KConfig> PromoRule_Detail_KConfig { get; set; }
        public DbSet<PromoRule_Detail_PConfig> PromoRule_Detail_PConfig { get; set; }
        public DbSet<PromoRule_Detail_PromotConfig> PromoRule_Detail_PromotConfig { get; set; }
        public DbSet<PromoRule_Detail_StoresConfig> PromoRule_Detail_StoresConfig { get; set; }
        public DbSet<PromoRule_Detail_VIPConfig> PromoRule_Detail_VIPConfig { get; set; }
        public DbSet<PromoRule_Stype> PromoRule_Stype { get; set; }
        public DbSet<PromotePrice> PromotePrices { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<ProxyInfo> ProxyInfoes { get; set; }
        public DbSet<ptype> ptypes { get; set; }
        public DbSet<ptype_8w> ptype_8w { get; set; }
        public DbSet<Ptype_CustomColumns> Ptype_CustomColumns { get; set; }
        public DbSet<ptype_l> ptype_l { get; set; }
        public DbSet<PType_Picture> PType_Picture { get; set; }
        public DbSet<PType_Price> PType_Price { get; set; }
        public DbSet<PType_STypePrice> PType_STypePrice { get; set; }
        public DbSet<PType_Units> PType_Units { get; set; }
        public DbSet<PType_Units_Ext> PType_Units_Ext { get; set; }
        public DbSet<PubRecord> PubRecords { get; set; }
        public DbSet<Pusercode> Pusercodes { get; set; }
        public DbSet<Qp_AttemperBill_RepairItemsPerson> Qp_AttemperBill_RepairItemsPerson { get; set; }
        public DbSet<QP_AutoType> QP_AutoType { get; set; }
        public DbSet<Qp_BackingOut_Bill> Qp_BackingOut_Bill { get; set; }
        public DbSet<Qp_BackType> Qp_BackType { get; set; }
        public DbSet<QP_ChargingStandards> QP_ChargingStandards { get; set; }
        public DbSet<QP_EvaluationBill_PType> QP_EvaluationBill_PType { get; set; }
        public DbSet<QP_EvaluationBill_RepairItems> QP_EvaluationBill_RepairItems { get; set; }
        public DbSet<Qp_InsuranceAuto> Qp_InsuranceAuto { get; set; }
        public DbSet<QP_InsuranceBill_PType> QP_InsuranceBill_PType { get; set; }
        public DbSet<QP_InsuranceBill_RepairItems> QP_InsuranceBill_RepairItems { get; set; }
        public DbSet<Qp_IntendingTalkBack_Bill> Qp_IntendingTalkBack_Bill { get; set; }
        public DbSet<QP_InvoiceOtherTotalDetails> QP_InvoiceOtherTotalDetails { get; set; }
        public DbSet<QP_InvoiceRepairItems> QP_InvoiceRepairItems { get; set; }
        public DbSet<QP_MiantenanceInfo> QP_MiantenanceInfo { get; set; }
        public DbSet<QP_nVipAddWashTimes> QP_nVipAddWashTimes { get; set; }
        public DbSet<QP_nVipCardSet_RepairItems_> QP_nVipCardSet_RepairItems_ { get; set; }
        public DbSet<QP_nVipCardSign_RemindEvent> QP_nVipCardSign_RemindEvent { get; set; }
        public DbSet<QP_nVipCardSign_RepairItems_> QP_nVipCardSign_RepairItems_ { get; set; }
        public DbSet<QP_OperationSort> QP_OperationSort { get; set; }
        public DbSet<Qp_PickingBackBill> Qp_PickingBackBill { get; set; }
        public DbSet<Qp_PickingBill> Qp_PickingBill { get; set; }
        public DbSet<QP_PType_Ext> QP_PType_Ext { get; set; }
        public DbSet<QP_QuickRepairBill_PType> QP_QuickRepairBill_PType { get; set; }
        public DbSet<QP_QuickRepairBill_RepairItems> QP_QuickRepairBill_RepairItems { get; set; }
        public DbSet<Qp_ReceptionBill_Accessory> Qp_ReceptionBill_Accessory { get; set; }
        public DbSet<Qp_ReceptionBill_FactUsePType> Qp_ReceptionBill_FactUsePType { get; set; }
        public DbSet<Qp_ReceptionBill_Insurance> Qp_ReceptionBill_Insurance { get; set; }
        public DbSet<Qp_ReceptionBill_Pic> Qp_ReceptionBill_Pic { get; set; }
        public DbSet<Qp_ReceptionBill_PType> Qp_ReceptionBill_PType { get; set; }
        public DbSet<Qp_ReceptionBill_RepairItems> Qp_ReceptionBill_RepairItems { get; set; }
        public DbSet<QP_RecycleBill> QP_RecycleBill { get; set; }
        public DbSet<QP_RepairAutoInfo> QP_RepairAutoInfo { get; set; }
        public DbSet<QP_RepairAutoType> QP_RepairAutoType { get; set; }
        public DbSet<QP_RepairItems> QP_RepairItems { get; set; }
        public DbSet<QP_RepairMode> QP_RepairMode { get; set; }
        public DbSet<QP_RepairSetMeal> QP_RepairSetMeal { get; set; }
        public DbSet<QP_RepairSetMeal_Fittings> QP_RepairSetMeal_Fittings { get; set; }
        public DbSet<QP_RepairSetMeal_Items> QP_RepairSetMeal_Items { get; set; }
        public DbSet<Qp_RepairState> Qp_RepairState { get; set; }
        public DbSet<Qp_SuccorBill> Qp_SuccorBill { get; set; }
        public DbSet<Qp_SuccorBill_ErrDescription> Qp_SuccorBill_ErrDescription { get; set; }
        public DbSet<Qp_SuccorBill_PType> Qp_SuccorBill_PType { get; set; }
        public DbSet<Qp_SuccorBill_RepairItems> Qp_SuccorBill_RepairItems { get; set; }
        public DbSet<Qp_SuccorBill_SuccorItems> Qp_SuccorBill_SuccorItems { get; set; }
        public DbSet<Qp_SuccorChargeItems> Qp_SuccorChargeItems { get; set; }
        public DbSet<Qp_SuccorType> Qp_SuccorType { get; set; }
        public DbSet<Qp_ThreePacketsBill_PType> Qp_ThreePacketsBill_PType { get; set; }
        public DbSet<Qp_ThreePacketsBill_RepairItems> Qp_ThreePacketsBill_RepairItems { get; set; }
        public DbSet<QP_Transport> QP_Transport { get; set; }
        public DbSet<QP_WashCarBill> QP_WashCarBill { get; set; }
        public DbSet<QP_WorkGroup> QP_WorkGroup { get; set; }
        public DbSet<QP_WorkGroup_Person> QP_WorkGroup_Person { get; set; }
        public DbSet<Qp_YearCheck> Qp_YearCheck { get; set; }
        public DbSet<QuotePriceBill> QuotePriceBills { get; set; }
        public DbSet<ReceiptBill> ReceiptBills { get; set; }
        public DbSet<ReceiptBillIndex> ReceiptBillIndexes { get; set; }
        public DbSet<ReferencePlanCommission> ReferencePlanCommissions { get; set; }
        public DbSet<ReferencePlanCommissionEtype> ReferencePlanCommissionEtypes { get; set; }
        public DbSet<ReferencePlanCommissionPlan> ReferencePlanCommissionPlans { get; set; }
        public DbSet<RefIndustry> RefIndustries { get; set; }
        public DbSet<RepairDeal> RepairDeals { get; set; }
        public DbSet<RepairDealDetail> RepairDealDetails { get; set; }
        public DbSet<RepairEngage> RepairEngages { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RequestBill> RequestBills { get; set; }
        public DbSet<RequestIndex> RequestIndexes { get; set; }
        public DbSet<RetailBackBill> RetailBackBills { get; set; }
        public DbSet<retailBill> retailBills { get; set; }
        public DbSet<RetailConfig> RetailConfigs { get; set; }
        public DbSet<SA_ConfigCollate> SA_ConfigCollate { get; set; }
        public DbSet<saleBackBill> saleBackBills { get; set; }
        public DbSet<SaleBill> SaleBills { get; set; }
        public DbSet<SaleGoodsExchangeBill> SaleGoodsExchangeBills { get; set; }
        public DbSet<SaleTime> SaleTimes { get; set; }
        public DbSet<SaleTimeTotal> SaleTimeTotals { get; set; }
        public DbSet<Scheme> Schemes { get; set; }
        public DbSet<SchemeConfig> SchemeConfigs { get; set; }
        public DbSet<SchemeDetail> SchemeDetails { get; set; }
        public DbSet<SchemeIndex> SchemeIndexes { get; set; }
        public DbSet<ScratchPad> ScratchPads { get; set; }
        public DbSet<SendBackBill> SendBackBills { get; set; }
        public DbSet<SendBill> SendBills { get; set; }
        public DbSet<SerialAdjustBill> SerialAdjustBills { get; set; }
        public DbSet<SerialAdjustIndex> SerialAdjustIndexes { get; set; }
        public DbSet<ServerDb> ServerDbs { get; set; }
        public DbSet<ShareFeeBill> ShareFeeBills { get; set; }
        public DbSet<ShareSourceBill> ShareSourceBills { get; set; }
        public DbSet<Sms_AlarmSendRule> Sms_AlarmSendRule { get; set; }
        public DbSet<Sms_AlarmVchDefine> Sms_AlarmVchDefine { get; set; }
        public DbSet<sms_BaseInfoMobile> sms_BaseInfoMobile { get; set; }
        public DbSet<SMS_CODEMOBIL_SET> SMS_CODEMOBIL_SET { get; set; }
        public DbSet<SMS_GROUPCODE_SET> SMS_GROUPCODE_SET { get; set; }
        public DbSet<SMS_GROUPMOBIL_SET> SMS_GROUPMOBIL_SET { get; set; }
        public DbSet<SMS_GROUPNAME_SET> SMS_GROUPNAME_SET { get; set; }
        public DbSet<sms_log> sms_log { get; set; }
        public DbSet<Sms_MessageRevice> Sms_MessageRevice { get; set; }
        public DbSet<sms_QueryCode_Set> sms_QueryCode_Set { get; set; }
        public DbSet<Sms_ReceiveLog> Sms_ReceiveLog { get; set; }
        public DbSet<Sms_SendPlan> Sms_SendPlan { get; set; }
        public DbSet<sms_SetSendRule> sms_SetSendRule { get; set; }
        public DbSet<sms_signature> sms_signature { get; set; }
        public DbSet<sms_Template> sms_Template { get; set; }
        public DbSet<sms_Template_Type> sms_Template_Type { get; set; }
        public DbSet<sp_SysProce> sp_SysProce { get; set; }
        public DbSet<sp_sysReportCondition> sp_sysReportCondition { get; set; }
        public DbSet<sp_sysReportCondition_Item> sp_sysReportCondition_Item { get; set; }
        public DbSet<sp_SysReportConditionList> sp_SysReportConditionList { get; set; }
        public DbSet<sp_SysTableName> sp_SysTableName { get; set; }
        public DbSet<sp_SysTEnItem> sp_SysTEnItem { get; set; }
        public DbSet<sqlLog> sqlLogs { get; set; }
        public DbSet<StartOk> StartOks { get; set; }
        public DbSet<StartOkItem> StartOkItems { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockAgeTimeConfig> StockAgeTimeConfigs { get; set; }
        public DbSet<StockCheck> StockChecks { get; set; }
        public DbSet<StockCheckIndex> StockCheckIndexes { get; set; }
        public DbSet<StockTotalConfig> StockTotalConfigs { get; set; }
        public DbSet<SType> STypes { get; set; }
        public DbSet<SType_Config> SType_Config { get; set; }
        public DbSet<Stype_CustomColumns> Stype_CustomColumns { get; set; }
        public DbSet<stype_l> stype_l { get; set; }
        public DbSet<SType_UserConfig> SType_UserConfig { get; set; }
        public DbSet<STypeMoveBill> STypeMoveBills { get; set; }
        public DbSet<StypeSaleAllPlan> StypeSaleAllPlans { get; set; }
        public DbSet<StypeSaleplan> StypeSaleplans { get; set; }
        public DbSet<Sys_BaseInfoUsing_Tables> Sys_BaseInfoUsing_Tables { get; set; }
        public DbSet<sysdata> sysdatas { get; set; }
        public DbSet<sysdata1> sysdata1 { get; set; }
        public DbSet<sysmovedata> sysmovedatas { get; set; }
        public DbSet<TaxInfo> TaxInfoes { get; set; }
        public DbSet<tbShowSet> tbShowSets { get; set; }
        public DbSet<TCBill> TCBills { get; set; }
        public DbSet<TCBillindex> TCBillindexes { get; set; }
        public DbSet<Te_AccountInTransit_Detail> Te_AccountInTransit_Detail { get; set; }
        public DbSet<Te_AccountInTransit_Index> Te_AccountInTransit_Index { get; set; }
        public DbSet<Te_Balance> Te_Balance { get; set; }
        public DbSet<Te_Bank> Te_Bank { get; set; }
        public DbSet<Te_BankAccount> Te_BankAccount { get; set; }
        public DbSet<Te_BankStatement> Te_BankStatement { get; set; }
        public DbSet<Te_BankStatementDetail> Te_BankStatementDetail { get; set; }
        public DbSet<Te_CheckRelevance> Te_CheckRelevance { get; set; }
        public DbSet<Te_InitDataDetail> Te_InitDataDetail { get; set; }
        public DbSet<Te_InitDataIndex> Te_InitDataIndex { get; set; }
        public DbSet<Te_Journal> Te_Journal { get; set; }
        public DbSet<Te_Journal_Detail> Te_Journal_Detail { get; set; }
        public DbSet<Te_Journal_SourceType> Te_Journal_SourceType { get; set; }
        public DbSet<Te_Period> Te_Period { get; set; }
        public DbSet<Te_StartPeriod> Te_StartPeriod { get; set; }
        public DbSet<TemplateListTable> TemplateListTables { get; set; }
        public DbSet<TemplateTable> TemplateTables { get; set; }
        public DbSet<tempPtype> tempPtypes { get; set; }
        public DbSet<ToolBill> ToolBills { get; set; }
        public DbSet<ToolIndex> ToolIndexes { get; set; }
        public DbSet<UFO_DefineFucType> UFO_DefineFucType { get; set; }
        public DbSet<UFO_DefineFunctions> UFO_DefineFunctions { get; set; }
        public DbSet<UFO_OpenFile> UFO_OpenFile { get; set; }
        public DbSet<UFO_ReportCategory> UFO_ReportCategory { get; set; }
        public DbSet<UFO_Temple> UFO_Temple { get; set; }
        public DbSet<UniteName> UniteNames { get; set; }
        public DbSet<UpdateVersionList> UpdateVersionLists { get; set; }
        public DbSet<upgradeVersionList> upgradeVersionLists { get; set; }
        public DbSet<Userconfig> Userconfigs { get; set; }
        public DbSet<UserGridConfig> UserGridConfigs { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserGroupLimit> UserGroupLimits { get; set; }
        public DbSet<UserGroupManage> UserGroupManages { get; set; }
        public DbSet<UserPowerRange> UserPowerRanges { get; set; }
        public DbSet<V3ZTInfo> V3ZTInfo { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<VacationDetail> VacationDetails { get; set; }
        public DbSet<VipAddMoneyBatchBill> VipAddMoneyBatchBills { get; set; }
        public DbSet<VipCardAutoZk> VipCardAutoZks { get; set; }
        public DbSet<VipCardConsume> VipCardConsumes { get; set; }
        public DbSet<VipCardSet> VipCardSets { get; set; }
        public DbSet<VipCardSign> VipCardSigns { get; set; }
        public DbSet<visit> visits { get; set; }
        public DbSet<visitfj> visitfjs { get; set; }
        public DbSet<VoucherSchemeDetail> VoucherSchemeDetails { get; set; }
        public DbSet<VoucherTemplatePreset> VoucherTemplatePresets { get; set; }
        public DbSet<webLog> webLogs { get; set; }
        public DbSet<WebMenu> WebMenus { get; set; }
        public DbSet<WeighBeamConfig> WeighBeamConfigs { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<wx_Bill_Call> wx_Bill_Call { get; set; }
        public DbSet<wx_Bill_GetBack> wx_Bill_GetBack { get; set; }
        public DbSet<wx_Bill_Goto> wx_Bill_Goto { get; set; }
        public DbSet<wx_Bill_In> wx_Bill_In { get; set; }
        public DbSet<wx_Bill_JieJian> wx_Bill_JieJian { get; set; }
        public DbSet<wx_Bill_Move> wx_Bill_Move { get; set; }
        public DbSet<wx_Bill_Out> wx_Bill_Out { get; set; }
        public DbSet<wx_Bill_Replace> wx_Bill_Replace { get; set; }
        public DbSet<wx_Bill_Self> wx_Bill_Self { get; set; }
        public DbSet<wx_Bill_Send> wx_Bill_Send { get; set; }
        public DbSet<wx_Bill_SendBack> wx_Bill_SendBack { get; set; }
        public DbSet<wx_ErrDescription> wx_ErrDescription { get; set; }
        public DbSet<wx_GoodsStocks> wx_GoodsStocks { get; set; }
        public DbSet<wx_IniGoodsStocks> wx_IniGoodsStocks { get; set; }
        public DbSet<wx_IniOutRepair> wx_IniOutRepair { get; set; }
        public DbSet<wx_InOutStockTable> wx_InOutStockTable { get; set; }
        public DbSet<wx_StockTotalConfig> wx_StockTotalConfig { get; set; }
        public DbSet<xw_Attachment> xw_Attachment { get; set; }
        public DbSet<xw_CustomReport> xw_CustomReport { get; set; }
        public DbSet<xw_Message> xw_Message { get; set; }
        public DbSet<xw_ProcedureBackup> xw_ProcedureBackup { get; set; }
        public DbSet<xw_SelfData> xw_SelfData { get; set; }
        public DbSet<xw_SelfDataType> xw_SelfDataType { get; set; }
        public DbSet<Yapi_BillSeedID> Yapi_BillSeedID { get; set; }
        public DbSet<Yapi_PtypeRelation> Yapi_PtypeRelation { get; set; }
        public DbSet<Yapi_SupplierPtypeRelation> Yapi_SupplierPtypeRelation { get; set; }
        public DbSet<Yapi_SupplierPtypeSeedID> Yapi_SupplierPtypeSeedID { get; set; }
        public DbSet<ZLCY_luntan> ZLCY_luntan { get; set; }
        public DbSet<ZLCYUpFile> ZLCYUpFiles { get; set; }
        public DbSet<CX_CombinationBillView> CX_CombinationBillView { get; set; }
        public DbSet<CX_CombinationDetailBillView> CX_CombinationDetailBillView { get; set; }
        public DbSet<CX_LargessBillView> CX_LargessBillView { get; set; }
        public DbSet<CX_SaleByHandView> CX_SaleByHandView { get; set; }
        public DbSet<CX_SalePlanIndexView> CX_SalePlanIndexView { get; set; }
        public DbSet<CX_SaleStocksAreaView> CX_SaleStocksAreaView { get; set; }
        public DbSet<CX_SpecialOfferBillView> CX_SpecialOfferBillView { get; set; }
        public DbSet<PosAssistAttributeView> PosAssistAttributeViews { get; set; }
        public DbSet<PosAssistTypeView> PosAssistTypeViews { get; set; }
        public DbSet<PosAtypeView> PosAtypeViews { get; set; }
        public DbSet<PosBarCodeTypeView> PosBarCodeTypeViews { get; set; }
        public DbSet<PosBarCodeView> PosBarCodeViews { get; set; }
        public DbSet<PosBranchView> PosBranchViews { get; set; }
        public DbSet<PosBtypeDistributeView> PosBtypeDistributeViews { get; set; }
        public DbSet<PosBtypeView> PosBtypeViews { get; set; }
        public DbSet<PosColorView> PosColorViews { get; set; }
        public DbSet<PosCxEPowerView> PosCxEPowerViews { get; set; }
        public DbSet<PosEmployeeView> PosEmployeeViews { get; set; }
        public DbSet<PosGoodsStocksDetailView> PosGoodsStocksDetailViews { get; set; }
        public DbSet<PosGoodsStocksView> PosGoodsStocksViews { get; set; }
        public DbSet<PosInfoView> PosInfoViews { get; set; }
        public DbSet<PosLoginUserView> PosLoginUserViews { get; set; }
        public DbSet<PosPriceTypeView> PosPriceTypeViews { get; set; }
        public DbSet<PosPtypeAttributeView> PosPtypeAttributeViews { get; set; }
        public DbSet<PosPtypeColorSizeView> PosPtypeColorSizeViews { get; set; }
        public DbSet<PosPtypePriceView> PosPtypePriceViews { get; set; }
        public DbSet<PosPtypeView> PosPtypeViews { get; set; }
        public DbSet<PosSizeView> PosSizeViews { get; set; }
        public DbSet<PosStockView> PosStockViews { get; set; }
        public DbSet<PosUserPowerRangeView> PosUserPowerRangeViews { get; set; }
        public DbSet<PosVipCardBoundView> PosVipCardBoundViews { get; set; }
        public DbSet<PosVipCardExpandView> PosVipCardExpandViews { get; set; }
        public DbSet<PosVipCardsView> PosVipCardsViews { get; set; }
        public DbSet<PosvipcardtypesView> PosvipcardtypesViews { get; set; }
        public DbSet<test_data> test_data { get; set; }
        public DbSet<v_getdate> v_getdate { get; set; }
        public DbSet<V_Item> V_Item { get; set; }
        public DbSet<V_LendFace> V_LendFace { get; set; }
        public DbSet<V_LendFace00> V_LendFace00 { get; set; }
        public DbSet<V_LendStatus> V_LendStatus { get; set; }
        public DbSet<vPtypeUnitALL> vPtypeUnitALLs { get; set; }
        public DbSet<vWeb_AdDebt> vWeb_AdDebt { get; set; }
        public DbSet<vWeb_AdPriceBill> vWeb_AdPriceBill { get; set; }
        public DbSet<vWeb_AdvantageBill> vWeb_AdvantageBill { get; set; }
        public DbSet<vWeb_ARAPIndex> vWeb_ARAPIndex { get; set; }
        public DbSet<vWeb_Balance> vWeb_Balance { get; set; }
        public DbSet<vWeb_Balance1> vWeb_Balance1 { get; set; }
        public DbSet<vWeb_BtypeAR> vWeb_BtypeAR { get; set; }
        public DbSet<vWeb_Gathering> vWeb_Gathering { get; set; }
        public DbSet<vWeb_GatheringPay_SaleBuy> vWeb_GatheringPay_SaleBuy { get; set; }
        public DbSet<vWeb_GiveBill> vWeb_GiveBill { get; set; }
        public DbSet<vWeb_GuestGet> vWeb_GuestGet { get; set; }
        public DbSet<vWeb_GuestWLDZ> vWeb_GuestWLDZ { get; set; }
        public DbSet<vWeb_HotList> vWeb_HotList { get; set; }
        public DbSet<vWeb_ItemIDByIsCombined> vWeb_ItemIDByIsCombined { get; set; }
        public DbSet<vWeb_LoseBill> vWeb_LoseBill { get; set; }
        public DbSet<vWeb_MoneyBill> vWeb_MoneyBill { get; set; }
        public DbSet<vWeb_MoveBill> vWeb_MoveBill { get; set; }
        public DbSet<vWeb_MoveBjBill> vWeb_MoveBjBill { get; set; }
        public DbSet<vWeb_OrderBill> vWeb_OrderBill { get; set; }
        public DbSet<vWeb_OrderBillFromBill> vWeb_OrderBillFromBill { get; set; }
        public DbSet<vWeb_OrderBillIndex> vWeb_OrderBillIndex { get; set; }
        public DbSet<vWeb_OrderBillIndex_New> vWeb_OrderBillIndex_New { get; set; }
        public DbSet<vWeb_OrderBillIndex_New_Xjkang> vWeb_OrderBillIndex_New_Xjkang { get; set; }
        public DbSet<vWeb_OrderBillIndex_NoBillStop> vWeb_OrderBillIndex_NoBillStop { get; set; }
        public DbSet<vWeb_OrderBillIndexHavingAuditing> vWeb_OrderBillIndexHavingAuditing { get; set; }
        public DbSet<vWeb_Pay> vWeb_Pay { get; set; }
        public DbSet<vWeb_PriceProtectBill> vWeb_PriceProtectBill { get; set; }
        public DbSet<vWeb_SaleBill> vWeb_SaleBill { get; set; }
        public DbSet<vWeb_SaleBillIndexConfirmed> vWeb_SaleBillIndexConfirmed { get; set; }
        public DbSet<vWeb_SaleBuy_GatheringPay> vWeb_SaleBuy_GatheringPay { get; set; }
        public DbSet<vWeb_StockCurDisByP> vWeb_StockCurDisByP { get; set; }
        public DbSet<vWeb_StockIniDisByP> vWeb_StockIniDisByP { get; set; }
        public DbSet<vWeb_WLDZ> vWeb_WLDZ { get; set; }
        public DbSet<vWeb_WLDZ_GYS> vWeb_WLDZ_GYS { get; set; }
        public DbSet<vWeb_WLDZ_GYS_YH> vWeb_WLDZ_GYS_YH { get; set; }
        public DbSet<vWeb_WLDZ_GYS_YH_1> vWeb_WLDZ_GYS_YH_1 { get; set; }
        public DbSet<vWeb_WLDZ_GYS_YH_TY> vWeb_WLDZ_GYS_YH_TY { get; set; }
        public DbSet<vWeb_WLDZ_GYS_YH_TY_1> vWeb_WLDZ_GYS_YH_TY_1 { get; set; }
        public DbSet<vWeb_WLDZ_GYS1> vWeb_WLDZ_GYS1 { get; set; }
        public DbSet<vWeb_WLDZ_YH> vWeb_WLDZ_YH { get; set; }
        public DbSet<vWeb_WLDZ_YH_1> vWeb_WLDZ_YH_1 { get; set; }
        public DbSet<vWeb_WLDZ_YH_TY> vWeb_WLDZ_YH_TY { get; set; }
        public DbSet<vWeb_WLDZ_YH_TY_1> vWeb_WLDZ_YH_TY_1 { get; set; }
        public DbSet<vWeb_WLDZ1> vWeb_WLDZ1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Ac_AccountMap());
            modelBuilder.Configurations.Add(new Ac_Account_Assist_CheckItemsMap());
            modelBuilder.Configurations.Add(new Ac_Account_Set_DetailMap());
            modelBuilder.Configurations.Add(new Ac_Account_Set_ListMap());
            modelBuilder.Configurations.Add(new Ac_AccountsPeroid_StypeMap());
            modelBuilder.Configurations.Add(new Ac_AssetBusinessTypeMap());
            modelBuilder.Configurations.Add(new Ac_AssetsCardsMap());
            modelBuilder.Configurations.Add(new Ac_AssetsCards_HistoryMap());
            modelBuilder.Configurations.Add(new Ac_AssetsCategoryMap());
            modelBuilder.Configurations.Add(new Ac_AssetsModifyRecordsMap());
            modelBuilder.Configurations.Add(new Ac_AssetStorageLocationMap());
            modelBuilder.Configurations.Add(new Ac_AssetWorkingConditionMap());
            modelBuilder.Configurations.Add(new Ac_Assist_CheckItemsMap());
            modelBuilder.Configurations.Add(new Ac_Assist_CheckItems_BillTypeMap());
            modelBuilder.Configurations.Add(new Ac_Assist_CheckItemsDetailMap());
            modelBuilder.Configurations.Add(new Ac_Auditing_TemplateMap());
            modelBuilder.Configurations.Add(new Ac_Auditing_Template_DetailMap());
            modelBuilder.Configurations.Add(new Ac_Auditing_Template_SummaryFiledMap());
            modelBuilder.Configurations.Add(new Ac_Balance_Assist_CheckItemsMap());
            modelBuilder.Configurations.Add(new Ac_Balance_Assist_CheckItems_DetailMap());
            modelBuilder.Configurations.Add(new Ac_BalanceTypeMap());
            modelBuilder.Configurations.Add(new Ac_BankMap());
            modelBuilder.Configurations.Add(new Ac_Batch_Bills_ResultMap());
            modelBuilder.Configurations.Add(new Ac_BillMoney_ListMap());
            modelBuilder.Configurations.Add(new Ac_CashMoneyItemsMap());
            modelBuilder.Configurations.Add(new Ac_CommissionBill_VoucherBillMap());
            modelBuilder.Configurations.Add(new Ac_CurrencyMap());
            modelBuilder.Configurations.Add(new Ac_DepreciationAlterationMap());
            modelBuilder.Configurations.Add(new Ac_DepreciationPlanMap());
            modelBuilder.Configurations.Add(new Ac_ExpensesMap());
            modelBuilder.Configurations.Add(new Ac_FixedAssetsMap());
            modelBuilder.Configurations.Add(new Ac_FixedAssetsInit_StypeMap());
            modelBuilder.Configurations.Add(new Ac_GoodsBill_VoucherBillMap());
            modelBuilder.Configurations.Add(new Ac_IniAccountMap());
            modelBuilder.Configurations.Add(new Ac_IniAccount_Assist_CheckItemsMap());
            modelBuilder.Configurations.Add(new Ac_IniAccount_Assist_CheckItems_DetailMap());
            modelBuilder.Configurations.Add(new Ac_ItemsMap());
            modelBuilder.Configurations.Add(new Ac_Items_DetailMap());
            modelBuilder.Configurations.Add(new Ac_MulColumnAccountMap());
            modelBuilder.Configurations.Add(new Ac_MulColumnAccount_AssistMap());
            modelBuilder.Configurations.Add(new Ac_OtherGainsMap());
            modelBuilder.Configurations.Add(new Ac_PeriodMap());
            modelBuilder.Configurations.Add(new Ac_ProfitAndLossMap());
            modelBuilder.Configurations.Add(new Ac_ProfitAndLoss_DetailMap());
            modelBuilder.Configurations.Add(new Ac_Provision_VoucherMap());
            modelBuilder.Configurations.Add(new Ac_ProvisionForImpairmentMap());
            modelBuilder.Configurations.Add(new Ac_ReceiptBill_VoucherBillMap());
            modelBuilder.Configurations.Add(new Ac_SubsidiaryEquipmentMap());
            modelBuilder.Configurations.Add(new Ac_TableMap());
            modelBuilder.Configurations.Add(new Ac_VoucherMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_BillMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Bill_Assist_CheckItemsMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Bill_CashMoneyItemsMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Bill_TempMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_CommonlyMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Commonly_BillMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Generate_Voucherbill_GoodsBillsMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_GroupMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Group_DetailMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_Repair_MsgMap());
            modelBuilder.Configurations.Add(new Ac_Voucher_TempMap());
            modelBuilder.Configurations.Add(new Ac_VoucherCommonly_Bill_Assist_CheckItemsMap());
            modelBuilder.Configurations.Add(new AccountCredenceMap());
            modelBuilder.Configurations.Add(new AccountInterFaceFileListMap());
            modelBuilder.Configurations.Add(new AccountSubjectSetMap());
            modelBuilder.Configurations.Add(new AccountTimeConfigMap());
            modelBuilder.Configurations.Add(new AdDebtBillMap());
            modelBuilder.Configurations.Add(new AddPrintCountRecordMap());
            modelBuilder.Configurations.Add(new AdPriceBillMap());
            modelBuilder.Configurations.Add(new AdvantageMap());
            modelBuilder.Configurations.Add(new Advantage_standardMap());
            modelBuilder.Configurations.Add(new AppraisalBackBillMap());
            modelBuilder.Configurations.Add(new AppraisalBillMap());
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new AreaTypeMap());
            modelBuilder.Configurations.Add(new Areatype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new AskPriceBillMap());
            modelBuilder.Configurations.Add(new AssetIncDecBillMap());
            modelBuilder.Configurations.Add(new AttendanceLimitMap());
            modelBuilder.Configurations.Add(new AttendanceTimeMap());
            modelBuilder.Configurations.Add(new atypeMap());
            modelBuilder.Configurations.Add(new atype_lMap());
            modelBuilder.Configurations.Add(new AType_TotalMap());
            modelBuilder.Configurations.Add(new AuditingBillMap());
            modelBuilder.Configurations.Add(new AuditingBillDetailMap());
            modelBuilder.Configurations.Add(new AuditingFlowDetailMap());
            modelBuilder.Configurations.Add(new AuditingFlowSetMap());
            modelBuilder.Configurations.Add(new AuditingReasonMap());
            modelBuilder.Configurations.Add(new AuditingRelationMap());
            modelBuilder.Configurations.Add(new AuditingStepReasonMap());
            modelBuilder.Configurations.Add(new AutoTypeMap());
            modelBuilder.Configurations.Add(new BalanceFileMap());
            modelBuilder.Configurations.Add(new Bank_lMap());
            modelBuilder.Configurations.Add(new BarCodeMap());
            modelBuilder.Configurations.Add(new BarCode_ExtMap());
            modelBuilder.Configurations.Add(new BarCode_SourceMap());
            modelBuilder.Configurations.Add(new BarCodeForBilltypeMap());
            modelBuilder.Configurations.Add(new BaseInfoAssitDetectionMap());
            modelBuilder.Configurations.Add(new BatchPriceMap());
            modelBuilder.Configurations.Add(new BATypeIdPresetMap());
            modelBuilder.Configurations.Add(new BBS_catalogMap());
            modelBuilder.Configurations.Add(new BBS_luntanMap());
            modelBuilder.Configurations.Add(new BBS_userinformationMap());
            modelBuilder.Configurations.Add(new BBSUpFileMap());
            modelBuilder.Configurations.Add(new BeforePromoteIndexMap());
            modelBuilder.Configurations.Add(new BeforePromoteRetailBillMap());
            modelBuilder.Configurations.Add(new BeforePromoteSaleBillMap());
            modelBuilder.Configurations.Add(new BillAttachFileMap());
            modelBuilder.Configurations.Add(new BillAttachFilesLogMap());
            modelBuilder.Configurations.Add(new BillAtypeMap());
            modelBuilder.Configurations.Add(new BillCode_SeedMap());
            modelBuilder.Configurations.Add(new BillHeadControlFieldMap());
            modelBuilder.Configurations.Add(new BillIndexMap());
            modelBuilder.Configurations.Add(new Billindex_CarRepairMap());
            modelBuilder.Configurations.Add(new BillMulAccountMap());
            modelBuilder.Configurations.Add(new BillNameMap());
            modelBuilder.Configurations.Add(new BillOperateLogMap());
            modelBuilder.Configurations.Add(new BillPrintConfigMap());
            modelBuilder.Configurations.Add(new BillSaveTimeLogMap());
            modelBuilder.Configurations.Add(new btypeMap());
            modelBuilder.Configurations.Add(new BType_ArApTotalMap());
            modelBuilder.Configurations.Add(new Btype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new btype_lMap());
            modelBuilder.Configurations.Add(new BType_PictureMap());
            modelBuilder.Configurations.Add(new BtypePriceInfoMap());
            modelBuilder.Configurations.Add(new BuyBackBillMap());
            modelBuilder.Configurations.Add(new BuyBillMap());
            modelBuilder.Configurations.Add(new BuyGoodsExchangeBillMap());
            modelBuilder.Configurations.Add(new CapitalTransfer_BillMap());
            modelBuilder.Configurations.Add(new CargoTypeMap());
            modelBuilder.Configurations.Add(new CarriageUnitMap());
            modelBuilder.Configurations.Add(new CashMoneyBillMap());
            modelBuilder.Configurations.Add(new ChargeOffBillMap());
            modelBuilder.Configurations.Add(new Chat_actionMap());
            modelBuilder.Configurations.Add(new Chat_autoactMap());
            modelBuilder.Configurations.Add(new Chat_descMap());
            modelBuilder.Configurations.Add(new Chat_guestbookMap());
            modelBuilder.Configurations.Add(new Chat_helpbodyMap());
            modelBuilder.Configurations.Add(new Chat_ip_lockMap());
            modelBuilder.Configurations.Add(new Chat_recordMap());
            modelBuilder.Configurations.Add(new Chat_roomMap());
            modelBuilder.Configurations.Add(new Chat_userMap());
            modelBuilder.Configurations.Add(new Chat_voteMap());
            modelBuilder.Configurations.Add(new Chat_vrecordMap());
            modelBuilder.Configurations.Add(new CheckBIllDataMap());
            modelBuilder.Configurations.Add(new cityMap());
            modelBuilder.Configurations.Add(new CM_CarInfoMap());
            modelBuilder.Configurations.Add(new CM_CarUseBillMap());
            modelBuilder.Configurations.Add(new CM_CarUseIndexMap());
            modelBuilder.Configurations.Add(new CM_FeeBillMap());
            modelBuilder.Configurations.Add(new CM_FeeIndexMap());
            modelBuilder.Configurations.Add(new CM_FeeTypeMap());
            modelBuilder.Configurations.Add(new CodeConfigMap());
            modelBuilder.Configurations.Add(new ColumnsFieldMap());
            modelBuilder.Configurations.Add(new CommissionBillMap());
            modelBuilder.Configurations.Add(new CommissionBillNewMap());
            modelBuilder.Configurations.Add(new CommissionBillNewDetailMap());
            modelBuilder.Configurations.Add(new CommissionRuleMap());
            modelBuilder.Configurations.Add(new CommissionRuleEtypeMap());
            modelBuilder.Configurations.Add(new CommissionRuleLeaderMap());
            modelBuilder.Configurations.Add(new CommissionRulePtypeMap());
            modelBuilder.Configurations.Add(new CommissionRuleRegionMap());
            modelBuilder.Configurations.Add(new CommissionSchemeMap());
            modelBuilder.Configurations.Add(new CommissionSchemeStypeMap());
            modelBuilder.Configurations.Add(new CommissionTypeMap());
            modelBuilder.Configurations.Add(new CommonPosInfoMap());
            modelBuilder.Configurations.Add(new CommonPosPtypeCheckListMap());
            modelBuilder.Configurations.Add(new CommonPosPtypeCheckNdxMap());
            modelBuilder.Configurations.Add(new CommonPosSaleIndexMap());
            modelBuilder.Configurations.Add(new CommonPosSaleIndexFreezeMap());
            modelBuilder.Configurations.Add(new CommonPosSaleIndexFreezeTempMap());
            modelBuilder.Configurations.Add(new CommonPosSaleIndexTempMap());
            modelBuilder.Configurations.Add(new CommonPosSaleListMap());
            modelBuilder.Configurations.Add(new CommonPosSaleListFreezeMap());
            modelBuilder.Configurations.Add(new CommonPosSaleListFreezeTempMap());
            modelBuilder.Configurations.Add(new CommonPosSaleListTempMap());
            modelBuilder.Configurations.Add(new CompleteGoodTotalMap());
            modelBuilder.Configurations.Add(new CompleteTotalMap());
            modelBuilder.Configurations.Add(new Cost_NoRelogMap());
            modelBuilder.Configurations.Add(new CostRe_BillMap());
            modelBuilder.Configurations.Add(new CostReLogMap());
            modelBuilder.Configurations.Add(new CPCX_catalogMap());
            modelBuilder.Configurations.Add(new CPCX_luntanMap());
            modelBuilder.Configurations.Add(new crm_btypeMap());
            modelBuilder.Configurations.Add(new CRM_BtypeSharedMap());
            modelBuilder.Configurations.Add(new crm_linkmanMap());
            modelBuilder.Configurations.Add(new CRM_LinkManSharedMap());
            modelBuilder.Configurations.Add(new Crm_MessageMap());
            modelBuilder.Configurations.Add(new Crm_MessageNoReadMap());
            modelBuilder.Configurations.Add(new Crm_ScheduleMap());
            modelBuilder.Configurations.Add(new Crm_Schedule_EtypeMap());
            modelBuilder.Configurations.Add(new Custom_ColumnMap());
            modelBuilder.Configurations.Add(new Custom_Column_BillDetailMap());
            modelBuilder.Configurations.Add(new Custom_ColumnTypeMap());
            modelBuilder.Configurations.Add(new Custom_DisplayColumnMap());
            modelBuilder.Configurations.Add(new Custom_DisplayColumnOrderMap());
            modelBuilder.Configurations.Add(new CustomBillColumnMap());
            modelBuilder.Configurations.Add(new CustomBillDetailColumnMap());
            modelBuilder.Configurations.Add(new customchangelogMap());
            modelBuilder.Configurations.Add(new CustomFieldDataMap());
            modelBuilder.Configurations.Add(new customPtypeItemMap());
            modelBuilder.Configurations.Add(new CustomReferenceMap());
            modelBuilder.Configurations.Add(new CustomReferenceValueMap());
            modelBuilder.Configurations.Add(new CX_CombinationBillMap());
            modelBuilder.Configurations.Add(new CX_CombinationDetailBillMap());
            modelBuilder.Configurations.Add(new CX_LargessBillMap());
            modelBuilder.Configurations.Add(new CX_SaleByHandMap());
            modelBuilder.Configurations.Add(new CX_SalePlanIndexMap());
            modelBuilder.Configurations.Add(new CX_SaleStocksAreaMap());
            modelBuilder.Configurations.Add(new CX_SpecialOfferBillMap());
            modelBuilder.Configurations.Add(new DbConfigMap());
            modelBuilder.Configurations.Add(new DefaultStockMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new DepBillMap());
            modelBuilder.Configurations.Add(new DepPlanBillMap());
            modelBuilder.Configurations.Add(new DepPlanIndexMap());
            modelBuilder.Configurations.Add(new DisassembleBillMap());
            modelBuilder.Configurations.Add(new distributingshowformatMap());
            modelBuilder.Configurations.Add(new DiyBillMap());
            modelBuilder.Configurations.Add(new DiyBillTypePSaleTypeIDMap());
            modelBuilder.Configurations.Add(new DiyIndexMap());
            modelBuilder.Configurations.Add(new DiyTypeMap());
            modelBuilder.Configurations.Add(new DiyTypePTypeIDMap());
            modelBuilder.Configurations.Add(new DocFileMap());
            modelBuilder.Configurations.Add(new DocFilePathMap());
            modelBuilder.Configurations.Add(new Dtype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new dtype_lMap());
            modelBuilder.Configurations.Add(new DtypeSaleAllPlanMap());
            modelBuilder.Configurations.Add(new DtypeSaleplanMap());
            modelBuilder.Configurations.Add(new employeeMap());
            modelBuilder.Configurations.Add(new EshopBaseInfoMap());
            modelBuilder.Configurations.Add(new EshopBillRelationMap());
            modelBuilder.Configurations.Add(new EshopGoodsInfoMap());
            modelBuilder.Configurations.Add(new Etype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new etype_lMap());
            modelBuilder.Configurations.Add(new EType_PictureMap());
            modelBuilder.Configurations.Add(new EtypeCommissionTypeMap());
            modelBuilder.Configurations.Add(new EtypeMacAndIPMap());
            modelBuilder.Configurations.Add(new EtypeSaleAllPlanMap());
            modelBuilder.Configurations.Add(new EtypeSaleplanMap());
            modelBuilder.Configurations.Add(new EventMap());
            modelBuilder.Configurations.Add(new EventLogMap());
            modelBuilder.Configurations.Add(new ExpressionMap());
            modelBuilder.Configurations.Add(new FaPiaoBillMap());
            modelBuilder.Configurations.Add(new FaPiaoBillIndexMap());
            modelBuilder.Configurations.Add(new fb_aMap());
            modelBuilder.Configurations.Add(new FixedAssetsDetailMap());
            modelBuilder.Configurations.Add(new FixedAssetsIndexMap());
            modelBuilder.Configurations.Add(new frtypeMap());
            modelBuilder.Configurations.Add(new FZ_ColorMap());
            modelBuilder.Configurations.Add(new FZ_ColorGroupMap());
            modelBuilder.Configurations.Add(new FZ_CurColorSizeMap());
            modelBuilder.Configurations.Add(new FZ_InitColorSizeMap());
            modelBuilder.Configurations.Add(new FZ_InOutColorSizeMap());
            modelBuilder.Configurations.Add(new FZ_SizeMap());
            modelBuilder.Configurations.Add(new FZ_SizeGroupMap());
            modelBuilder.Configurations.Add(new FZ_SizeMatchingMap());
            modelBuilder.Configurations.Add(new gatheringBillMap());
            modelBuilder.Configurations.Add(new GBtype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new GDSETCODEMap());
            modelBuilder.Configurations.Add(new GiveBillMap());
            modelBuilder.Configurations.Add(new GiveFromSaleOrBuyMap());
            modelBuilder.Configurations.Add(new GiveFromSaleOrBuyBillMap());
            modelBuilder.Configurations.Add(new GivemeBillMap());
            modelBuilder.Configurations.Add(new GoodsExchangeBillMap());
            modelBuilder.Configurations.Add(new GoodsLocalMap());
            modelBuilder.Configurations.Add(new GOODSSTOCKS_QTYMap());
            modelBuilder.Configurations.Add(new gp_CruPtypeSerialMap());
            modelBuilder.Configurations.Add(new gp_initLendPtypeSerialMap());
            modelBuilder.Configurations.Add(new gp_initPtypeSerialMap());
            modelBuilder.Configurations.Add(new gp_inoutPtypeSerialMap());
            modelBuilder.Configurations.Add(new gp_LendPtypeSerialMap());
            modelBuilder.Configurations.Add(new GuestBackMap());
            modelBuilder.Configurations.Add(new GuestBackIndexMap());
            modelBuilder.Configurations.Add(new GuestGetMap());
            modelBuilder.Configurations.Add(new GuestGetIndexMap());
            modelBuilder.Configurations.Add(new GuestPayMap());
            modelBuilder.Configurations.Add(new GuestPayIndexMap());
            modelBuilder.Configurations.Add(new HotlistMap());
            modelBuilder.Configurations.Add(new HR_DepartmentMap());
            modelBuilder.Configurations.Add(new HR_ImgMap());
            modelBuilder.Configurations.Add(new HR_InterviewDirectionMap());
            modelBuilder.Configurations.Add(new HR_InterviewerEstimateMap());
            modelBuilder.Configurations.Add(new HR_NextEstimateTimesMap());
            modelBuilder.Configurations.Add(new HR_PersonMap());
            modelBuilder.Configurations.Add(new HR_PersonEduMap());
            modelBuilder.Configurations.Add(new HR_PersonFamilyMap());
            modelBuilder.Configurations.Add(new HR_PersonLimitMap());
            modelBuilder.Configurations.Add(new HR_PersonStatusMap());
            modelBuilder.Configurations.Add(new HR_PersonWorkExpMap());
            modelBuilder.Configurations.Add(new HR_PostionMap());
            modelBuilder.Configurations.Add(new HR_TaskMap());
            modelBuilder.Configurations.Add(new HR_TaskDistributionMap());
            modelBuilder.Configurations.Add(new HR_TaskEstimateMap());
            modelBuilder.Configurations.Add(new HR_TaskStatusMap());
            modelBuilder.Configurations.Add(new IM_MessageMap());
            modelBuilder.Configurations.Add(new IM_Message_NoSocketMap());
            modelBuilder.Configurations.Add(new ImportPriceTempMap());
            modelBuilder.Configurations.Add(new ImportPtypeTempMap());
            modelBuilder.Configurations.Add(new ImportPtypeTemp1Map());
            modelBuilder.Configurations.Add(new ImportStateMap());
            modelBuilder.Configurations.Add(new IndexChartDataMap());
            modelBuilder.Configurations.Add(new Ini_GOODSSTOCKS_QTYMap());
            modelBuilder.Configurations.Add(new IniBType_ArApTotalMap());
            modelBuilder.Configurations.Add(new IniCommissionStockMap());
            modelBuilder.Configurations.Add(new IniStockAgeGroupMap());
            modelBuilder.Configurations.Add(new IniStockAgeStockMap());
            modelBuilder.Configurations.Add(new IniStockAgeStypeMap());
            modelBuilder.Configurations.Add(new InitSaleSeralIndexMap());
            modelBuilder.Configurations.Add(new initSaleSerialbillMap());
            modelBuilder.Configurations.Add(new InOutstocktableMap());
            modelBuilder.Configurations.Add(new IntegralExchangeBillMap());
            modelBuilder.Configurations.Add(new IntercourseSettingMap());
            modelBuilder.Configurations.Add(new InvoiceBillMap());
            modelBuilder.Configurations.Add(new IsStartOkMap());
            modelBuilder.Configurations.Add(new ItemATypeIdPresetMap());
            modelBuilder.Configurations.Add(new ItemTypeMap());
            modelBuilder.Configurations.Add(new ItemType_ItemMap());
            modelBuilder.Configurations.Add(new KinOutStockConfigMap());
            modelBuilder.Configurations.Add(new Ktype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new ktype_lMap());
            modelBuilder.Configurations.Add(new LeaveReasonMap());
            modelBuilder.Configurations.Add(new LendBillMap());
            modelBuilder.Configurations.Add(new LendIndexMap());
            modelBuilder.Configurations.Add(new ListTableMap());
            modelBuilder.Configurations.Add(new LocalDetailMap());
            modelBuilder.Configurations.Add(new LocalIndexMap());
            modelBuilder.Configurations.Add(new LoginLogMap());
            modelBuilder.Configurations.Add(new LoginManageInfoMap());
            modelBuilder.Configurations.Add(new loginuserMap());
            modelBuilder.Configurations.Add(new LoginUserColMap());
            modelBuilder.Configurations.Add(new LoseBillMap());
            modelBuilder.Configurations.Add(new LTypeMap());
            modelBuilder.Configurations.Add(new ManageBTypeMap());
            modelBuilder.Configurations.Add(new ManualRegistMap());
            modelBuilder.Configurations.Add(new MenuTemplateConfigMap());
            modelBuilder.Configurations.Add(new ModifyLog_AppraisalBackBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_AppraisalBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_BillIndexMap());
            modelBuilder.Configurations.Add(new ModifyLog_BuyBackBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_BuyBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_CompleteGoodTotalMap());
            modelBuilder.Configurations.Add(new ModifyLog_CompleteTotalMap());
            modelBuilder.Configurations.Add(new ModifyLog_GatheringBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_PayBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_PreBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_ReceiptBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_ReceiptBillIndexMap());
            modelBuilder.Configurations.Add(new ModifyLog_SaleBackBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_SaleBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_SendBackBillMap());
            modelBuilder.Configurations.Add(new ModifyLog_SendBillMap());
            modelBuilder.Configurations.Add(new MoneyBillMap());
            modelBuilder.Configurations.Add(new MonthATypeHistoryMap());
            modelBuilder.Configurations.Add(new MonthProcMap());
            modelBuilder.Configurations.Add(new MoveBillMap());
            modelBuilder.Configurations.Add(new MoveBjBillMap());
            modelBuilder.Configurations.Add(new MoveMoneyBillMap());
            modelBuilder.Configurations.Add(new Msg_MessageListMap());
            modelBuilder.Configurations.Add(new Msg_OnlineMap());
            modelBuilder.Configurations.Add(new newsMap());
            modelBuilder.Configurations.Add(new news_catalogMap());
            modelBuilder.Configurations.Add(new NotePadMap());
            modelBuilder.Configurations.Add(new nVipAddMoneyMap());
            modelBuilder.Configurations.Add(new nVipAdjustMap());
            modelBuilder.Configurations.Add(new nVipCardSetMap());
            modelBuilder.Configurations.Add(new NVipCardSetLogMap());
            modelBuilder.Configurations.Add(new nVipCardSignMap());
            modelBuilder.Configurations.Add(new nVipCardTypeChangeMap());
            modelBuilder.Configurations.Add(new nVipGoodsSignMap());
            modelBuilder.Configurations.Add(new nVipJfRuleMap());
            modelBuilder.Configurations.Add(new nVipJfSetMap());
            modelBuilder.Configurations.Add(new OA_ASP_DispatchMap());
            modelBuilder.Configurations.Add(new OA_AttachmentMap());
            modelBuilder.Configurations.Add(new OA_CatalogMap());
            modelBuilder.Configurations.Add(new OA_MessageMap());
            modelBuilder.Configurations.Add(new OA_Message_BakMap());
            modelBuilder.Configurations.Add(new OA_OnlineUserMap());
            modelBuilder.Configurations.Add(new OA_PersonalDesktopMap());
            modelBuilder.Configurations.Add(new OA_PersonalMsgNotify_ANDMap());
            modelBuilder.Configurations.Add(new OA_PersonalMsgNotify_ORMap());
            modelBuilder.Configurations.Add(new OA_PrivateDBMap());
            modelBuilder.Configurations.Add(new OA_ProductMap());
            modelBuilder.Configurations.Add(new OA_PublicDBMap());
            modelBuilder.Configurations.Add(new OA_RightMap());
            modelBuilder.Configurations.Add(new OA_RightTemplateDetailMap());
            modelBuilder.Configurations.Add(new OA_RightTemplateTypeMap());
            modelBuilder.Configurations.Add(new OA_SubscibeMap());
            modelBuilder.Configurations.Add(new OA_UserInformationMap());
            modelBuilder.Configurations.Add(new OA_Vote_EmployeeVoteInfoMap());
            modelBuilder.Configurations.Add(new OFF_FtypeMap());
            modelBuilder.Configurations.Add(new OFF_RightMap());
            modelBuilder.Configurations.Add(new Offline_BillMap());
            modelBuilder.Configurations.Add(new Offline_BillIndexMap());
            modelBuilder.Configurations.Add(new OFFLINE_TASKMap());
            modelBuilder.Configurations.Add(new OftenCommentMap());
            modelBuilder.Configurations.Add(new OftenExplainMap());
            modelBuilder.Configurations.Add(new OftenMenuMap());
            modelBuilder.Configurations.Add(new Old_BillMap());
            modelBuilder.Configurations.Add(new Old_BillMulAccountMap());
            modelBuilder.Configurations.Add(new Old_CompleteGoodTotalMap());
            modelBuilder.Configurations.Add(new Old_CompleteTotalMap());
            modelBuilder.Configurations.Add(new Old_GatheringBillMap());
            modelBuilder.Configurations.Add(new Old_ListtableMap());
            modelBuilder.Configurations.Add(new Old_PayBillMap());
            modelBuilder.Configurations.Add(new Old_PreBillMap());
            modelBuilder.Configurations.Add(new OM_BackBillCodeSeedMap());
            modelBuilder.Configurations.Add(new OM_BackCartMap());
            modelBuilder.Configurations.Add(new OM_BackOrderMap());
            modelBuilder.Configurations.Add(new OM_BackOrderDetailMap());
            modelBuilder.Configurations.Add(new OM_BillCodeSeedMap());
            modelBuilder.Configurations.Add(new OM_BillIndexMap());
            modelBuilder.Configurations.Add(new OM_CartsMap());
            modelBuilder.Configurations.Add(new OM_DeliveryAddressMap());
            modelBuilder.Configurations.Add(new OM_DiscountBillMap());
            modelBuilder.Configurations.Add(new OM_InventoryMap());
            modelBuilder.Configurations.Add(new OM_Inventory_ExtMap());
            modelBuilder.Configurations.Add(new OM_InvoceBillMap());
            modelBuilder.Configurations.Add(new OM_LoginUserLevealMap());
            modelBuilder.Configurations.Add(new OM_LoginUsersMap());
            modelBuilder.Configurations.Add(new OM_OrderMap());
            modelBuilder.Configurations.Add(new OM_OrderDetailMap());
            modelBuilder.Configurations.Add(new OM_OrderDetailsMap());
            modelBuilder.Configurations.Add(new OM_PtypeMap());
            modelBuilder.Configurations.Add(new OM_Ptype_lMap());
            modelBuilder.Configurations.Add(new OM_PtypeClassMap());
            modelBuilder.Configurations.Add(new OM_QuestionReplyMap());
            modelBuilder.Configurations.Add(new OM_ReplacementGoodsMap());
            modelBuilder.Configurations.Add(new OM_ReturnGoodsMap());
            modelBuilder.Configurations.Add(new OM_ShipmentsMap());
            modelBuilder.Configurations.Add(new OM_ShoppingCartMap());
            modelBuilder.Configurations.Add(new OM_SqlLogMap());
            modelBuilder.Configurations.Add(new OMBillAttachFileMap());
            modelBuilder.Configurations.Add(new OMBillCode_SeedMap());
            modelBuilder.Configurations.Add(new OMBillShipmentMap());
            modelBuilder.Configurations.Add(new Ord_AssemblyInfoMap());
            modelBuilder.Configurations.Add(new Ord_LimitListMap());
            modelBuilder.Configurations.Add(new Ord_PlugMap());
            modelBuilder.Configurations.Add(new Ord_PlugInstallLogMap());
            modelBuilder.Configurations.Add(new Ord_PlugLimitFootingMap());
            modelBuilder.Configurations.Add(new Ord_PopUpPageMap());
            modelBuilder.Configurations.Add(new OrderBillMap());
            modelBuilder.Configurations.Add(new OrderFiledSchemeDetailMap());
            modelBuilder.Configurations.Add(new OrderIndexMap());
            modelBuilder.Configurations.Add(new OtherInOutBillMap());
            modelBuilder.Configurations.Add(new OtherInOutTypeMap());
            modelBuilder.Configurations.Add(new overflowBillMap());
            modelBuilder.Configurations.Add(new PayBillMap());
            modelBuilder.Configurations.Add(new PerformanceDistributionMap());
            modelBuilder.Configurations.Add(new PloyTypeMap());
            modelBuilder.Configurations.Add(new Plug_EventLogMap());
            modelBuilder.Configurations.Add(new Plug_UserGroupMap());
            modelBuilder.Configurations.Add(new Pos_AdvertisementPicMap());
            modelBuilder.Configurations.Add(new Pos_PicUpdateRecordMap());
            modelBuilder.Configurations.Add(new Pos_UploadDogInfoMap());
            modelBuilder.Configurations.Add(new Pos_UploadPicRecordMap());
            modelBuilder.Configurations.Add(new POSBankRateInfoMap());
            modelBuilder.Configurations.Add(new PosCommonSysDataMap());
            modelBuilder.Configurations.Add(new PosDataUpdatedMap());
            modelBuilder.Configurations.Add(new PosInfoMap());
            modelBuilder.Configurations.Add(new PosIsUpdateDataMap());
            modelBuilder.Configurations.Add(new PosMulAccountMap());
            modelBuilder.Configurations.Add(new PosMulAccountAllMap());
            modelBuilder.Configurations.Add(new PosRetailCashMap());
            modelBuilder.Configurations.Add(new PosRetailRecordMap());
            modelBuilder.Configurations.Add(new PosSaleBillMap());
            modelBuilder.Configurations.Add(new PosSaleBillAllMap());
            modelBuilder.Configurations.Add(new PosSaleBillIndexMap());
            modelBuilder.Configurations.Add(new PosSaleMergeFailedMap());
            modelBuilder.Configurations.Add(new PosVipMoneyListMap());
            modelBuilder.Configurations.Add(new PreBillMap());
            modelBuilder.Configurations.Add(new PriceBillIndexMap());
            modelBuilder.Configurations.Add(new PriceBillIndex_StypeMap());
            modelBuilder.Configurations.Add(new PriceDetailMap());
            modelBuilder.Configurations.Add(new PriceDetailDeletedMap());
            modelBuilder.Configurations.Add(new PriceProtectMap());
            modelBuilder.Configurations.Add(new PriceProtectBillMap());
            modelBuilder.Configurations.Add(new PriceRuleMap());
            modelBuilder.Configurations.Add(new PriceRule_Detail_BConfigMap());
            modelBuilder.Configurations.Add(new PriceRule_Detail_DConfigMap());
            modelBuilder.Configurations.Add(new PriceRule_Detail_EConfigMap());
            modelBuilder.Configurations.Add(new PriceRule_Detail_KConfigMap());
            modelBuilder.Configurations.Add(new PriceRule_Detail_StoresConfigMap());
            modelBuilder.Configurations.Add(new PriceRule_Detail_VipConfigMap());
            modelBuilder.Configurations.Add(new PriceRule_StypeMap());
            modelBuilder.Configurations.Add(new PriceRulePriorityMap());
            modelBuilder.Configurations.Add(new PriceTrackMap());
            modelBuilder.Configurations.Add(new PriceTrack_AppraisalMap());
            modelBuilder.Configurations.Add(new PriceTrack_SendMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_AppraisalMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_AskPriceMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_BuyMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_BuyOrderMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_QuoteMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_SaleMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_SaleOrderMap());
            modelBuilder.Configurations.Add(new PriceTrack_SType_SendMap());
            modelBuilder.Configurations.Add(new PriceTrack_STypeMoveMap());
            modelBuilder.Configurations.Add(new PrintRecordMap());
            modelBuilder.Configurations.Add(new ProduceModelMap());
            modelBuilder.Configurations.Add(new ProduceModelIndexMap());
            modelBuilder.Configurations.Add(new PromoRuleMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_BtypeConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_EConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_KConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_PConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_PromotConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_StoresConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_Detail_VIPConfigMap());
            modelBuilder.Configurations.Add(new PromoRule_StypeMap());
            modelBuilder.Configurations.Add(new PromotePriceMap());
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new ProxyInfoMap());
            modelBuilder.Configurations.Add(new ptypeMap());
            modelBuilder.Configurations.Add(new ptype_8wMap());
            modelBuilder.Configurations.Add(new Ptype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new ptype_lMap());
            modelBuilder.Configurations.Add(new PType_PictureMap());
            modelBuilder.Configurations.Add(new PType_PriceMap());
            modelBuilder.Configurations.Add(new PType_STypePriceMap());
            modelBuilder.Configurations.Add(new PType_UnitsMap());
            modelBuilder.Configurations.Add(new PType_Units_ExtMap());
            modelBuilder.Configurations.Add(new PubRecordMap());
            modelBuilder.Configurations.Add(new PusercodeMap());
            modelBuilder.Configurations.Add(new Qp_AttemperBill_RepairItemsPersonMap());
            modelBuilder.Configurations.Add(new QP_AutoTypeMap());
            modelBuilder.Configurations.Add(new Qp_BackingOut_BillMap());
            modelBuilder.Configurations.Add(new Qp_BackTypeMap());
            modelBuilder.Configurations.Add(new QP_ChargingStandardsMap());
            modelBuilder.Configurations.Add(new QP_EvaluationBill_PTypeMap());
            modelBuilder.Configurations.Add(new QP_EvaluationBill_RepairItemsMap());
            modelBuilder.Configurations.Add(new Qp_InsuranceAutoMap());
            modelBuilder.Configurations.Add(new QP_InsuranceBill_PTypeMap());
            modelBuilder.Configurations.Add(new QP_InsuranceBill_RepairItemsMap());
            modelBuilder.Configurations.Add(new Qp_IntendingTalkBack_BillMap());
            modelBuilder.Configurations.Add(new QP_InvoiceOtherTotalDetailsMap());
            modelBuilder.Configurations.Add(new QP_InvoiceRepairItemsMap());
            modelBuilder.Configurations.Add(new QP_MiantenanceInfoMap());
            modelBuilder.Configurations.Add(new QP_nVipAddWashTimesMap());
            modelBuilder.Configurations.Add(new QP_nVipCardSet_RepairItems_Map());
            modelBuilder.Configurations.Add(new QP_nVipCardSign_RemindEventMap());
            modelBuilder.Configurations.Add(new QP_nVipCardSign_RepairItems_Map());
            modelBuilder.Configurations.Add(new QP_OperationSortMap());
            modelBuilder.Configurations.Add(new Qp_PickingBackBillMap());
            modelBuilder.Configurations.Add(new Qp_PickingBillMap());
            modelBuilder.Configurations.Add(new QP_PType_ExtMap());
            modelBuilder.Configurations.Add(new QP_QuickRepairBill_PTypeMap());
            modelBuilder.Configurations.Add(new QP_QuickRepairBill_RepairItemsMap());
            modelBuilder.Configurations.Add(new Qp_ReceptionBill_AccessoryMap());
            modelBuilder.Configurations.Add(new Qp_ReceptionBill_FactUsePTypeMap());
            modelBuilder.Configurations.Add(new Qp_ReceptionBill_InsuranceMap());
            modelBuilder.Configurations.Add(new Qp_ReceptionBill_PicMap());
            modelBuilder.Configurations.Add(new Qp_ReceptionBill_PTypeMap());
            modelBuilder.Configurations.Add(new Qp_ReceptionBill_RepairItemsMap());
            modelBuilder.Configurations.Add(new QP_RecycleBillMap());
            modelBuilder.Configurations.Add(new QP_RepairAutoInfoMap());
            modelBuilder.Configurations.Add(new QP_RepairAutoTypeMap());
            modelBuilder.Configurations.Add(new QP_RepairItemsMap());
            modelBuilder.Configurations.Add(new QP_RepairModeMap());
            modelBuilder.Configurations.Add(new QP_RepairSetMealMap());
            modelBuilder.Configurations.Add(new QP_RepairSetMeal_FittingsMap());
            modelBuilder.Configurations.Add(new QP_RepairSetMeal_ItemsMap());
            modelBuilder.Configurations.Add(new Qp_RepairStateMap());
            modelBuilder.Configurations.Add(new Qp_SuccorBillMap());
            modelBuilder.Configurations.Add(new Qp_SuccorBill_ErrDescriptionMap());
            modelBuilder.Configurations.Add(new Qp_SuccorBill_PTypeMap());
            modelBuilder.Configurations.Add(new Qp_SuccorBill_RepairItemsMap());
            modelBuilder.Configurations.Add(new Qp_SuccorBill_SuccorItemsMap());
            modelBuilder.Configurations.Add(new Qp_SuccorChargeItemsMap());
            modelBuilder.Configurations.Add(new Qp_SuccorTypeMap());
            modelBuilder.Configurations.Add(new Qp_ThreePacketsBill_PTypeMap());
            modelBuilder.Configurations.Add(new Qp_ThreePacketsBill_RepairItemsMap());
            modelBuilder.Configurations.Add(new QP_TransportMap());
            modelBuilder.Configurations.Add(new QP_WashCarBillMap());
            modelBuilder.Configurations.Add(new QP_WorkGroupMap());
            modelBuilder.Configurations.Add(new QP_WorkGroup_PersonMap());
            modelBuilder.Configurations.Add(new Qp_YearCheckMap());
            modelBuilder.Configurations.Add(new QuotePriceBillMap());
            modelBuilder.Configurations.Add(new ReceiptBillMap());
            modelBuilder.Configurations.Add(new ReceiptBillIndexMap());
            modelBuilder.Configurations.Add(new ReferencePlanCommissionMap());
            modelBuilder.Configurations.Add(new ReferencePlanCommissionEtypeMap());
            modelBuilder.Configurations.Add(new ReferencePlanCommissionPlanMap());
            modelBuilder.Configurations.Add(new RefIndustryMap());
            modelBuilder.Configurations.Add(new RepairDealMap());
            modelBuilder.Configurations.Add(new RepairDealDetailMap());
            modelBuilder.Configurations.Add(new RepairEngageMap());
            modelBuilder.Configurations.Add(new ReportMap());
            modelBuilder.Configurations.Add(new RequestBillMap());
            modelBuilder.Configurations.Add(new RequestIndexMap());
            modelBuilder.Configurations.Add(new RetailBackBillMap());
            modelBuilder.Configurations.Add(new retailBillMap());
            modelBuilder.Configurations.Add(new RetailConfigMap());
            modelBuilder.Configurations.Add(new SA_ConfigCollateMap());
            modelBuilder.Configurations.Add(new saleBackBillMap());
            modelBuilder.Configurations.Add(new SaleBillMap());
            modelBuilder.Configurations.Add(new SaleGoodsExchangeBillMap());
            modelBuilder.Configurations.Add(new SaleTimeMap());
            modelBuilder.Configurations.Add(new SaleTimeTotalMap());
            modelBuilder.Configurations.Add(new SchemeMap());
            modelBuilder.Configurations.Add(new SchemeConfigMap());
            modelBuilder.Configurations.Add(new SchemeDetailMap());
            modelBuilder.Configurations.Add(new SchemeIndexMap());
            modelBuilder.Configurations.Add(new ScratchPadMap());
            modelBuilder.Configurations.Add(new SendBackBillMap());
            modelBuilder.Configurations.Add(new SendBillMap());
            modelBuilder.Configurations.Add(new SerialAdjustBillMap());
            modelBuilder.Configurations.Add(new SerialAdjustIndexMap());
            modelBuilder.Configurations.Add(new ServerDbMap());
            modelBuilder.Configurations.Add(new ShareFeeBillMap());
            modelBuilder.Configurations.Add(new ShareSourceBillMap());
            modelBuilder.Configurations.Add(new Sms_AlarmSendRuleMap());
            modelBuilder.Configurations.Add(new Sms_AlarmVchDefineMap());
            modelBuilder.Configurations.Add(new sms_BaseInfoMobileMap());
            modelBuilder.Configurations.Add(new SMS_CODEMOBIL_SETMap());
            modelBuilder.Configurations.Add(new SMS_GROUPCODE_SETMap());
            modelBuilder.Configurations.Add(new SMS_GROUPMOBIL_SETMap());
            modelBuilder.Configurations.Add(new SMS_GROUPNAME_SETMap());
            modelBuilder.Configurations.Add(new sms_logMap());
            modelBuilder.Configurations.Add(new Sms_MessageReviceMap());
            modelBuilder.Configurations.Add(new sms_QueryCode_SetMap());
            modelBuilder.Configurations.Add(new Sms_ReceiveLogMap());
            modelBuilder.Configurations.Add(new Sms_SendPlanMap());
            modelBuilder.Configurations.Add(new sms_SetSendRuleMap());
            modelBuilder.Configurations.Add(new sms_signatureMap());
            modelBuilder.Configurations.Add(new sms_TemplateMap());
            modelBuilder.Configurations.Add(new sms_Template_TypeMap());
            modelBuilder.Configurations.Add(new sp_SysProceMap());
            modelBuilder.Configurations.Add(new sp_sysReportConditionMap());
            modelBuilder.Configurations.Add(new sp_sysReportCondition_ItemMap());
            modelBuilder.Configurations.Add(new sp_SysReportConditionListMap());
            modelBuilder.Configurations.Add(new sp_SysTableNameMap());
            modelBuilder.Configurations.Add(new sp_SysTEnItemMap());
            modelBuilder.Configurations.Add(new sqlLogMap());
            modelBuilder.Configurations.Add(new StartOkMap());
            modelBuilder.Configurations.Add(new StartOkItemMap());
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new StockAgeTimeConfigMap());
            modelBuilder.Configurations.Add(new StockCheckMap());
            modelBuilder.Configurations.Add(new StockCheckIndexMap());
            modelBuilder.Configurations.Add(new StockTotalConfigMap());
            modelBuilder.Configurations.Add(new STypeMap());
            modelBuilder.Configurations.Add(new SType_ConfigMap());
            modelBuilder.Configurations.Add(new Stype_CustomColumnsMap());
            modelBuilder.Configurations.Add(new stype_lMap());
            modelBuilder.Configurations.Add(new SType_UserConfigMap());
            modelBuilder.Configurations.Add(new STypeMoveBillMap());
            modelBuilder.Configurations.Add(new StypeSaleAllPlanMap());
            modelBuilder.Configurations.Add(new StypeSaleplanMap());
            modelBuilder.Configurations.Add(new Sys_BaseInfoUsing_TablesMap());
            modelBuilder.Configurations.Add(new sysdataMap());
            modelBuilder.Configurations.Add(new sysdata1Map());
            modelBuilder.Configurations.Add(new sysmovedataMap());
            modelBuilder.Configurations.Add(new TaxInfoMap());
            modelBuilder.Configurations.Add(new tbShowSetMap());
            modelBuilder.Configurations.Add(new TCBillMap());
            modelBuilder.Configurations.Add(new TCBillindexMap());
            modelBuilder.Configurations.Add(new Te_AccountInTransit_DetailMap());
            modelBuilder.Configurations.Add(new Te_AccountInTransit_IndexMap());
            modelBuilder.Configurations.Add(new Te_BalanceMap());
            modelBuilder.Configurations.Add(new Te_BankMap());
            modelBuilder.Configurations.Add(new Te_BankAccountMap());
            modelBuilder.Configurations.Add(new Te_BankStatementMap());
            modelBuilder.Configurations.Add(new Te_BankStatementDetailMap());
            modelBuilder.Configurations.Add(new Te_CheckRelevanceMap());
            modelBuilder.Configurations.Add(new Te_InitDataDetailMap());
            modelBuilder.Configurations.Add(new Te_InitDataIndexMap());
            modelBuilder.Configurations.Add(new Te_JournalMap());
            modelBuilder.Configurations.Add(new Te_Journal_DetailMap());
            modelBuilder.Configurations.Add(new Te_Journal_SourceTypeMap());
            modelBuilder.Configurations.Add(new Te_PeriodMap());
            modelBuilder.Configurations.Add(new Te_StartPeriodMap());
            modelBuilder.Configurations.Add(new TemplateListTableMap());
            modelBuilder.Configurations.Add(new TemplateTableMap());
            modelBuilder.Configurations.Add(new tempPtypeMap());
            modelBuilder.Configurations.Add(new ToolBillMap());
            modelBuilder.Configurations.Add(new ToolIndexMap());
            modelBuilder.Configurations.Add(new UFO_DefineFucTypeMap());
            modelBuilder.Configurations.Add(new UFO_DefineFunctionsMap());
            modelBuilder.Configurations.Add(new UFO_OpenFileMap());
            modelBuilder.Configurations.Add(new UFO_ReportCategoryMap());
            modelBuilder.Configurations.Add(new UFO_TempleMap());
            modelBuilder.Configurations.Add(new UniteNameMap());
            modelBuilder.Configurations.Add(new UpdateVersionListMap());
            modelBuilder.Configurations.Add(new upgradeVersionListMap());
            modelBuilder.Configurations.Add(new UserconfigMap());
            modelBuilder.Configurations.Add(new UserGridConfigMap());
            modelBuilder.Configurations.Add(new UserGroupMap());
            modelBuilder.Configurations.Add(new UserGroupLimitMap());
            modelBuilder.Configurations.Add(new UserGroupManageMap());
            modelBuilder.Configurations.Add(new UserPowerRangeMap());
            modelBuilder.Configurations.Add(new V3ZTInfoMap());
            modelBuilder.Configurations.Add(new VacationMap());
            modelBuilder.Configurations.Add(new VacationDetailMap());
            modelBuilder.Configurations.Add(new VipAddMoneyBatchBillMap());
            modelBuilder.Configurations.Add(new VipCardAutoZkMap());
            modelBuilder.Configurations.Add(new VipCardConsumeMap());
            modelBuilder.Configurations.Add(new VipCardSetMap());
            modelBuilder.Configurations.Add(new VipCardSignMap());
            modelBuilder.Configurations.Add(new visitMap());
            modelBuilder.Configurations.Add(new visitfjMap());
            modelBuilder.Configurations.Add(new VoucherSchemeDetailMap());
            modelBuilder.Configurations.Add(new VoucherTemplatePresetMap());
            modelBuilder.Configurations.Add(new webLogMap());
            modelBuilder.Configurations.Add(new WebMenuMap());
            modelBuilder.Configurations.Add(new WeighBeamConfigMap());
            modelBuilder.Configurations.Add(new WorkTimeMap());
            modelBuilder.Configurations.Add(new wx_Bill_CallMap());
            modelBuilder.Configurations.Add(new wx_Bill_GetBackMap());
            modelBuilder.Configurations.Add(new wx_Bill_GotoMap());
            modelBuilder.Configurations.Add(new wx_Bill_InMap());
            modelBuilder.Configurations.Add(new wx_Bill_JieJianMap());
            modelBuilder.Configurations.Add(new wx_Bill_MoveMap());
            modelBuilder.Configurations.Add(new wx_Bill_OutMap());
            modelBuilder.Configurations.Add(new wx_Bill_ReplaceMap());
            modelBuilder.Configurations.Add(new wx_Bill_SelfMap());
            modelBuilder.Configurations.Add(new wx_Bill_SendMap());
            modelBuilder.Configurations.Add(new wx_Bill_SendBackMap());
            modelBuilder.Configurations.Add(new wx_ErrDescriptionMap());
            modelBuilder.Configurations.Add(new wx_GoodsStocksMap());
            modelBuilder.Configurations.Add(new wx_IniGoodsStocksMap());
            modelBuilder.Configurations.Add(new wx_IniOutRepairMap());
            modelBuilder.Configurations.Add(new wx_InOutStockTableMap());
            modelBuilder.Configurations.Add(new wx_StockTotalConfigMap());
            modelBuilder.Configurations.Add(new xw_AttachmentMap());
            modelBuilder.Configurations.Add(new xw_CustomReportMap());
            modelBuilder.Configurations.Add(new xw_MessageMap());
            modelBuilder.Configurations.Add(new xw_ProcedureBackupMap());
            modelBuilder.Configurations.Add(new xw_SelfDataMap());
            modelBuilder.Configurations.Add(new xw_SelfDataTypeMap());
            modelBuilder.Configurations.Add(new Yapi_BillSeedIDMap());
            modelBuilder.Configurations.Add(new Yapi_PtypeRelationMap());
            modelBuilder.Configurations.Add(new Yapi_SupplierPtypeRelationMap());
            modelBuilder.Configurations.Add(new Yapi_SupplierPtypeSeedIDMap());
            modelBuilder.Configurations.Add(new ZLCY_luntanMap());
            modelBuilder.Configurations.Add(new ZLCYUpFileMap());
            modelBuilder.Configurations.Add(new CX_CombinationBillViewMap());
            modelBuilder.Configurations.Add(new CX_CombinationDetailBillViewMap());
            modelBuilder.Configurations.Add(new CX_LargessBillViewMap());
            modelBuilder.Configurations.Add(new CX_SaleByHandViewMap());
            modelBuilder.Configurations.Add(new CX_SalePlanIndexViewMap());
            modelBuilder.Configurations.Add(new CX_SaleStocksAreaViewMap());
            modelBuilder.Configurations.Add(new CX_SpecialOfferBillViewMap());
            modelBuilder.Configurations.Add(new PosAssistAttributeViewMap());
            modelBuilder.Configurations.Add(new PosAssistTypeViewMap());
            modelBuilder.Configurations.Add(new PosAtypeViewMap());
            modelBuilder.Configurations.Add(new PosBarCodeTypeViewMap());
            modelBuilder.Configurations.Add(new PosBarCodeViewMap());
            modelBuilder.Configurations.Add(new PosBranchViewMap());
            modelBuilder.Configurations.Add(new PosBtypeDistributeViewMap());
            modelBuilder.Configurations.Add(new PosBtypeViewMap());
            modelBuilder.Configurations.Add(new PosColorViewMap());
            modelBuilder.Configurations.Add(new PosCxEPowerViewMap());
            modelBuilder.Configurations.Add(new PosEmployeeViewMap());
            modelBuilder.Configurations.Add(new PosGoodsStocksDetailViewMap());
            modelBuilder.Configurations.Add(new PosGoodsStocksViewMap());
            modelBuilder.Configurations.Add(new PosInfoViewMap());
            modelBuilder.Configurations.Add(new PosLoginUserViewMap());
            modelBuilder.Configurations.Add(new PosPriceTypeViewMap());
            modelBuilder.Configurations.Add(new PosPtypeAttributeViewMap());
            modelBuilder.Configurations.Add(new PosPtypeColorSizeViewMap());
            modelBuilder.Configurations.Add(new PosPtypePriceViewMap());
            modelBuilder.Configurations.Add(new PosPtypeViewMap());
            modelBuilder.Configurations.Add(new PosSizeViewMap());
            modelBuilder.Configurations.Add(new PosStockViewMap());
            modelBuilder.Configurations.Add(new PosUserPowerRangeViewMap());
            modelBuilder.Configurations.Add(new PosVipCardBoundViewMap());
            modelBuilder.Configurations.Add(new PosVipCardExpandViewMap());
            modelBuilder.Configurations.Add(new PosVipCardsViewMap());
            modelBuilder.Configurations.Add(new PosvipcardtypesViewMap());
            modelBuilder.Configurations.Add(new test_dataMap());
            modelBuilder.Configurations.Add(new v_getdateMap());
            modelBuilder.Configurations.Add(new V_ItemMap());
            modelBuilder.Configurations.Add(new V_LendFaceMap());
            modelBuilder.Configurations.Add(new V_LendFace00Map());
            modelBuilder.Configurations.Add(new V_LendStatusMap());
            modelBuilder.Configurations.Add(new vPtypeUnitALLMap());
            modelBuilder.Configurations.Add(new vWeb_AdDebtMap());
            modelBuilder.Configurations.Add(new vWeb_AdPriceBillMap());
            modelBuilder.Configurations.Add(new vWeb_AdvantageBillMap());
            modelBuilder.Configurations.Add(new vWeb_ARAPIndexMap());
            modelBuilder.Configurations.Add(new vWeb_BalanceMap());
            modelBuilder.Configurations.Add(new vWeb_Balance1Map());
            modelBuilder.Configurations.Add(new vWeb_BtypeARMap());
            modelBuilder.Configurations.Add(new vWeb_GatheringMap());
            modelBuilder.Configurations.Add(new vWeb_GatheringPay_SaleBuyMap());
            modelBuilder.Configurations.Add(new vWeb_GiveBillMap());
            modelBuilder.Configurations.Add(new vWeb_GuestGetMap());
            modelBuilder.Configurations.Add(new vWeb_GuestWLDZMap());
            modelBuilder.Configurations.Add(new vWeb_HotListMap());
            modelBuilder.Configurations.Add(new vWeb_ItemIDByIsCombinedMap());
            modelBuilder.Configurations.Add(new vWeb_LoseBillMap());
            modelBuilder.Configurations.Add(new vWeb_MoneyBillMap());
            modelBuilder.Configurations.Add(new vWeb_MoveBillMap());
            modelBuilder.Configurations.Add(new vWeb_MoveBjBillMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillFromBillMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillIndexMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillIndex_NewMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillIndex_New_XjkangMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillIndex_NoBillStopMap());
            modelBuilder.Configurations.Add(new vWeb_OrderBillIndexHavingAuditingMap());
            modelBuilder.Configurations.Add(new vWeb_PayMap());
            modelBuilder.Configurations.Add(new vWeb_PriceProtectBillMap());
            modelBuilder.Configurations.Add(new vWeb_SaleBillMap());
            modelBuilder.Configurations.Add(new vWeb_SaleBillIndexConfirmedMap());
            modelBuilder.Configurations.Add(new vWeb_SaleBuy_GatheringPayMap());
            modelBuilder.Configurations.Add(new vWeb_StockCurDisByPMap());
            modelBuilder.Configurations.Add(new vWeb_StockIniDisByPMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_GYSMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_GYS_YHMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_GYS_YH_1Map());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_GYS_YH_TYMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_GYS_YH_TY_1Map());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_GYS1Map());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_YHMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_YH_1Map());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_YH_TYMap());
            modelBuilder.Configurations.Add(new vWeb_WLDZ_YH_TY_1Map());
            modelBuilder.Configurations.Add(new vWeb_WLDZ1Map());
        }
    }
}
