TYPE
	PlcOutputs : STRUCT
		ST80_1_DM260_EB_Box_Acquisition_Control_1 : BYTE;
		ST80_1_DM260_EB_Box_Results_Control_1 : BYTE;
		ST80_1_DM260_EB_Box_Soft_Event_Control_1 : BYTE;
		ST80_1_DM260_EB_Box_User_Data_64_bytes_1 : ARRAY[0..67] OF BYTE;
		ST80_1_CMMT_1GF1_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 : ARRAY[0..23] OF BYTE;
		ST80_1_CMMT_1GF2_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 : ARRAY[0..23] OF BYTE;
		ST80_1_DM260_PB_Box_Acquisition_Control_1 : BYTE;
		ST80_1_DM260_PB_Box_Results_Control_1 : BYTE;
		ST80_1_DM260_PB_Box_Soft_Event_Control_1 : BYTE;
		ST80_1_DM260_PB_Box_User_Data_64_bytes_1 : ARRAY[0..67] OF BYTE;
		ST80_ET200SP_2_11M1 : WORD;
		ST80_ET200SP_2_11M2 : WORD;
		ST80_ET200SP_2_11M3 : WORD;
		ST80_ET200SP_2_11M4 : WORD;
		ST80_ET200SP_2_12M1 : WORD;
		ST80_ET200SP_2_12M2 : WORD;
		ST80_ET200SP_2_12M3 : WORD;
		ST80_ET200SP_2_12M4 : WORD;
		ST80_ET200SP_2_13M1 : WORD;
		ST80_ET200SP_2_13M2 : WORD;
		ST80_ET200SP_2_13M3 : WORD;
		ST80_ET200SP_2_13M4 : WORD;
		ST80_1_TZ535_PN_In_Out_32_byte_1 : ARRAY[0..31] OF BYTE;
		ST80_1_DM260_Housing_Acquisition_Control_1 : BYTE;
		ST80_1_DM260_Housing_Results_Control_1 : BYTE;
		ST80_1_DM260_Housing_Soft_Event_Control_1 : BYTE;
		ST80_1_DM260_Housing_User_Data_64_bytes_1 : ARRAY[0..67] OF BYTE;
		ST80_1_CMMT_3GF1_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 : ARRAY[0..23] OF BYTE;
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 : BYTE;
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_2 : BYTE;
		ST80_CPX_MPA2S_VMPA2_FB_EMS_4_4DO_1 : BYTE;
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_3 : BYTE;
		ST80_CPX_MPA2S_VMPA2_FB_EMS_4_4DO_2 : BYTE;
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_4 : BYTE;
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_5 : BYTE;
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_1 : BYTE;
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_2 : BYTE;
		ST80_CPX_MPA2G_VMPA2_FB_EMG_4_4DO_1 : BYTE;
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_3 : BYTE;
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_4 : BYTE;
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_5 : BYTE;
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_6 : BYTE;
		ST80_ET200SP_CM_4xIO_Link_1 : ARRAY[0..31] OF BYTE;
		ST80_ET200SP_CM_4xIO_Link_2 : ARRAY[0..31] OF BYTE;
		ST80_ET200SP_CM_4xIO_Link_3 : ARRAY[0..31] OF BYTE;
		ST80_ET200SP_DQ_16x24VDC_0_5A_ST_1 : WORD;
		ST80_ET200SP_DQ_16x24VDC_0_5A_ST_2 : WORD;
		ST80_ET200SP_DQ_16x24VDC_0_5A_ST_3 : WORD;
	END_STRUCT;
END_TYPE