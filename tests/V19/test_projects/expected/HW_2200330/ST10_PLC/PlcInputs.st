TYPE
	PlcInputs : STRUCT
		ST10_ET200SP_CM_AS_i_Master_ST_1 : ARRAY[0..63] OF BYTE;
		ST10_ET200SP_DI_8x24VDC_ST_1 : BYTE;
		ST10_ET200SP_DI_16x24VDC_ST_2 : WORD;
		ST10_ET200SP_DI_16x24VDC_ST_3 : WORD;
		ST10_ET200SP_DI_8x24VDC_ST_2 : BYTE;
		ST10_ET200SP_CM_4xIO_Link_1 : ARRAY[0..31] OF BYTE;
		ST10_ET200SP_2_21FM1 : DWORD;
		ST10_ET200SP_2_21FM2 : DWORD;
		ST10_ET200SP_2_21FM3 : DWORD;
		ST10_ET200SP_2_21FM4 : DWORD;
		ST10_ET200SP_2_21FM5 : DWORD;
		ST10_ET200SP_2_21FM6 : DWORD;
		ST10_ET200SP_2_21FM7 : DWORD;
		ST10_ET200SP_2_21FM8 : DWORD;
		ST10_ET200SP_2_21FM9 : DWORD;
		ST10_ET200SP_2_21FM10 : DWORD;
		ST10_ET200SP_2_21FM11 : DWORD;
		ST10_ET200SP_2_21FM12 : DWORD;
		ST10_ET200SP_2_22FM1 : DWORD;
		ST10_ET200SP_2_22FM2 : DWORD;
		ST10_ET200SP_2_22FM3 : DWORD;
		ST10_ET200SP_2_22FM4 : DWORD;
		ST10_ET200SP_2_22FM5 : DWORD;
		ST10_ET200SP_2_22FM6 : DWORD;
		ST10_ET200SP_2_22FM7 : DWORD;
		ST10_ET200SP_2_22FM8 : DWORD;
		ST10_ET200SP_2_22FM9 : DWORD;
		ST10_ET200SP_2_22FM10 : DWORD;
		ST10_ET200SP_2_22FM11 : DWORD;
		ST10_ET200SP_2_22FM12 : DWORD;
		ST10_ET200SP_2_22FM13 : DWORD;
		ST10_1_DM260_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST10_1_DM260_Results_Status_1 : BYTE;
		ST10_1_DM260_Soft_Event_Control_1 : BYTE;
		ST10_1_DM260_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		ST10_1_DM260_Turned_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		ST10_1_DM260_Turned_Results_Status_1 : BYTE;
		ST10_1_DM260_Turned_Soft_Event_Control_1 : BYTE;
		ST10_1_DM260_Turned_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
	END_STRUCT;
END_TYPE