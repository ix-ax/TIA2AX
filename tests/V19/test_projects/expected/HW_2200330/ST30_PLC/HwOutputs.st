TYPE
	HwOutputs : STRUCT
		ST30_ET200SP_CM_4xIO_Link_1 AT %B100 : ARRAY[0..31] OF BYTE;
		ST30_ET200SP_CM_4xIO_Link_2 AT %B132 : ARRAY[0..31] OF BYTE;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_1 AT %B0 : WORD;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_2 AT %B2 : WORD;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_3 AT %B4 : WORD;
		ST30_ET200SP_DQ_16x24VDC_0_5A_ST_4 AT %B6 : WORD;
		ST30_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 AT %B200 : BYTE;
		ST30_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_1 AT %B201 : BYTE;
		ST30_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_2 AT %B202 : BYTE;
		ST30_1_ACT350_Measuring_Block_1_MB_Command_Value AT %B1000 : DWORD;
		ST30_1_ACT350_Measuring_Block_1_MB_Channel_Mask AT %B1004 : WORD;
		ST30_1_ACT350_Measuring_Block_1_MB_Command AT %B1006 : WORD;
		ST30_1_ACT350_Status_Block_1_SB_Reserved_1 AT %B1010 : WORD;
		ST30_1_ACT350_Status_Block_1_SB_Reserved_2 AT %B1012 : WORD;
		ST30_1_ACT350_Status_Block_1_SB_Reserved_3 AT %B1014 : WORD;
		ST30_1_ACT350_Status_Block_1_SB_Command AT %B1016 : WORD;
		ST30_1_DM260_Acquisition_Control_1 AT %B1500 : BYTE;
		ST30_1_DM260_Results_Control_1 AT %B1503 : BYTE;
		ST30_1_DM260_Soft_Event_Control_1 AT %B1504 : BYTE;
		ST30_1_DM260_User_Data_64_bytes_1 AT %B1510 : ARRAY[0..67] OF BYTE;
		ST30_1_CMMT_AS_X_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B1100 : ARRAY[0..23] OF BYTE;
		ST30_1_CMMT_AS_Y_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B1200 : ARRAY[0..23] OF BYTE;
		ST30_1_CMMT_AS_Z_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B1300 : ARRAY[0..23] OF BYTE;
		ST30_2_ACT350_Measuring_Block_1_MB_Command_Value AT %B2000 : DWORD;
		ST30_2_ACT350_Measuring_Block_1_MB_Channel_Mask AT %B2004 : WORD;
		ST30_2_ACT350_Measuring_Block_1_MB_Command AT %B2006 : WORD;
		ST30_2_ACT350_Status_Block_1_SB_Reserved_1 AT %B2010 : WORD;
		ST30_2_ACT350_Status_Block_1_SB_Reserved_2 AT %B2012 : WORD;
		ST30_2_ACT350_Status_Block_1_SB_Reserved_3 AT %B2014 : WORD;
		ST30_2_ACT350_Status_Block_1_SB_Command AT %B2016 : WORD;
		ST30_2_CMMT_AS_X_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B2100 : ARRAY[0..23] OF BYTE;
		ST30_2_CMMT_AS_Y_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B2200 : ARRAY[0..23] OF BYTE;
		ST30_2_CMMT_AS_Z_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B2300 : ARRAY[0..23] OF BYTE;
		ST30_2_DM260_Acquisition_Control_1 AT %B2500 : BYTE;
		ST30_2_DM260_Results_Control_1 AT %B2503 : BYTE;
		ST30_2_DM260_Soft_Event_Control_1 AT %B2504 : BYTE;
		ST30_2_DM260_User_Data_64_bytes_1 AT %B2510 : ARRAY[0..67] OF BYTE;
	END_STRUCT;
END_TYPE