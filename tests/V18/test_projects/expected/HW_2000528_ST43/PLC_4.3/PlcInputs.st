TYPE
	PlcInputs : STRUCT
		wp4_3_dm262_l_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		wp4_3_dm262_l_Results_Status_1 : BYTE;
		wp4_3_dm262_l_Soft_Event_Control_1 : BYTE;
		wp4_3_dm262_l_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ET_200SP_ST43_A3 : ARRAY[0..7] OF BYTE;
		ET_200SP_ST43_A4 : ARRAY[0..7] OF BYTE;
		ET_200SP_ST43_A5 : ARRAY[0..7] OF BYTE;
		ET_200SP_ST43_DI_16x24VDC_ST_1 : WORD;
		ET_200SP_ST43_DI_16x24VDC_ST_2 : WORD;
		ET_200SP_ST43_DI_16x24VDC_ST_3 : WORD;
		ET_200SP_ST43_DI_16x24VDC_ST_4 : WORD;
		ET_200SP_ST43_TM_Pulse_2x24V_1 : ARRAY[0..15] OF BYTE;
		ET_200SP_ST43_TM_Pulse_2x24V_2 : ARRAY[0..15] OF BYTE;
		ET_200SP_ST43_TM_Pulse_2x24V_3 : ARRAY[0..15] OF BYTE;
		ET_200SP_ST43_TM_Pulse_2x24V_4 : ARRAY[0..15] OF BYTE;
		ET_200SP_ST43_TM_Pulse_2x24V_5 : ARRAY[0..15] OF BYTE;
		wp4_3_dm262_r_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		wp4_3_dm262_r_Results_Status_1 : BYTE;
		wp4_3_dm262_r_Soft_Event_Control_1 : BYTE;
		wp4_3_dm262_r_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
	END_STRUCT;
END_TYPE
