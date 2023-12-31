TYPE
	PlcOutputs : STRUCT
		ST30_ET200SP_CM_4xIO_Link_1 : ARRAY[0..31] OF BYTE;
		ST30_ET200SP_CM_4xIO_Link_2 : ARRAY[0..31] OF BYTE;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_1 : WORD;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_2 : WORD;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_3 : WORD;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_4 : WORD;
		ST30_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 : BYTE;
		ST30_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_1 : BYTE;
		ST30_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_2 : BYTE;
		ST30_1_DM260_Acquisition_Control_1 : BYTE;
		ST30_1_DM260_Results_Control_1 : BYTE;
		ST30_1_DM260_Soft_Event_Control_1 : BYTE;
		ST30_1_DM260_User_Data_64_bytes_1 : ARRAY[0..67] OF BYTE;
		ST30_2_DM260_Acquisition_Control_1 : BYTE;
		ST30_2_DM260_Results_Control_1 : BYTE;
		ST30_2_DM260_Soft_Event_Control_1 : BYTE;
		ST30_2_DM260_User_Data_64_bytes_1 : ARRAY[0..67] OF BYTE;
	END_STRUCT;
END_TYPE
