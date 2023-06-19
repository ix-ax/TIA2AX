TYPE
	PlcInputs : STRUCT
		ST70_ET200SP_CM_4xIO_Link_1 : ARRAY[0..31] OF BYTE;
		ST70_ET200SP_DI_16x24VDC_ST_1 : WORD;
		ST70_ET200SP_DI_16x24VDC_ST_2 : WORD;
		ST70_ET200SP_DI_8x24VDC_ST_3 : BYTE;
		ST70_ET200SP_DI_16x24VDC_ST_4 : WORD;
		ST70_1_DM260_PB_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST70_1_DM260_PB_Results_Status_1 : BYTE;
		ST70_1_DM260_PB_Soft_Event_Control_1 : BYTE;
		ST70_1_DM260_PB_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ST70_2_DM260_PB_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST70_2_DM260_PB_Results_Status_1 : BYTE;
		ST70_2_DM260_PB_Soft_Event_Control_1 : BYTE;
		ST70_2_DM260_PB_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ST70_3_DM260_PB_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST70_3_DM260_PB_Results_Status_1 : BYTE;
		ST70_3_DM260_PB_Soft_Event_Control_1 : BYTE;
		ST70_3_DM260_PB_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ST70_1_DM260_EB_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST70_1_DM260_EB_Results_Status_1 : BYTE;
		ST70_1_DM260_EB_Soft_Event_Control_1 : BYTE;
		ST70_1_DM260_EB_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ST70_2_DM260_EB_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST70_2_DM260_EB_Results_Status_1 : BYTE;
		ST70_2_DM260_EB_Soft_Event_Control_1 : BYTE;
		ST70_2_DM260_EB_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ST70_3_DM260_EB_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST70_3_DM260_EB_Results_Status_1 : BYTE;
		ST70_3_DM260_EB_Soft_Event_Control_1 : BYTE;
		ST70_3_DM260_EB_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
	END_STRUCT;
END_TYPE
