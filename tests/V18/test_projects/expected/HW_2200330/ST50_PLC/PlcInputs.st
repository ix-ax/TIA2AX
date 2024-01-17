TYPE
	PlcInputs : STRUCT
		ST50_ET200SP_CM_4xIO_Link_1 : ARRAY[0..31] OF BYTE;
		ST50_ET200SP_CM_4xIO_Link_2 : ARRAY[0..31] OF BYTE;
		ST50_ET200SP_DI_16x24VDC_ST_1 : WORD;
		ST50_ET200SP_DI_16x24VDC_ST_2 : WORD;
		ST50_ET200SP_DI_8x24VDC_ST_4 : BYTE;
		ST50_ET200SP_DI_8x24VDC_ST_3 : BYTE;
		ST50_SCHUNK_L_IN_4_Double_Words : ARRAY[0..15] OF BYTE;
		ST50_SCHUNK_R_IN_4_Double_Words : ARRAY[0..15] OF BYTE;
		ST50_TZ535_PN_In_Out_32_byte_x : ARRAY[0..31] OF BYTE;
		ST50_1_DM260_WPC_Acquisition_Status : ARRAY[0..2] OF BYTE;
		ST50_1_DM260_WPC_Results_Status : BYTE;
		ST50_1_DM260_WPC_Soft_Event_Control : BYTE;
		ST50_1_DM260_WPC_Result_Data_64_bytes : ARRAY[0..71] OF BYTE;
		ST50_1_DM260_Acquisition_Status : ARRAY[0..2] OF BYTE;
		ST50_1_DM260_Results_Status : BYTE;
		ST50_1_DM260_Soft_Event_Control : BYTE;
		ST50_1_DM260_Result_Data_64_bytes : ARRAY[0..71] OF BYTE;
		ST50_2_DM260_Acquisition_Status : ARRAY[0..2] OF BYTE;
		ST50_2_DM260_Results_Status : BYTE;
		ST50_2_DM260_Soft_Event_Control : BYTE;
		ST50_2_DM260_Result_Data_64_bytes : ARRAY[0..71] OF BYTE;
		ST50_3_DM260_Acquisition_Status : ARRAY[0..2] OF BYTE;
		ST50_3_DM260_Results_Status : BYTE;
		ST50_3_DM260_Soft_Event_Control : BYTE;
		ST50_3_DM260_Result_Data_64_bytes : ARRAY[0..71] OF BYTE;
		ST50_4_DM260_Acquisition_Status : ARRAY[0..2] OF BYTE;
		ST50_4_DM260_Results_Status : BYTE;
		ST50_4_DM260_Soft_Event_Control : BYTE;
		ST50_4_DM260_Result_Data_64_bytes : ARRAY[0..71] OF BYTE;
	END_STRUCT;
END_TYPE
