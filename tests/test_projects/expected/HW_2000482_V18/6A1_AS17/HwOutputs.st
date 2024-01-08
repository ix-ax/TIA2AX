TYPE
	HwOutputs : STRUCT
		CMMT_AS17_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 AT %B119 : ARRAY[0..23] OF BYTE;
		_6A2_AS17_6A5 AT %B0 : WORD;
		_6A2_AS17_6A6 AT %B2 : WORD;
		_6A2_AS17_6A13 AT %B87 : ARRAY[0..31] OF BYTE;
		HousingReader_AS17_Latch_and_Error_Clear_Control_Bits_1 AT %B6 : BYTE;
		HousingReader_AS17_Operation_instruction_Control_Bits_1 AT %B7 : BYTE;
		HousingReader_AS17_Completion_Clear_Control_Bits_1 AT %B12 : BYTE;
		HousingReader_AS17_Parameter_Bank_Number_1 AT %B51 : WORD;
		HousingReader_AS17_User_Data_128Byte_1 AT %B193 : ARRAY[0..129] OF BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_1 AT %B13 : BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_2 AT %B183 : BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_3 AT %B184 : BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_4 AT %B185 : BYTE;
		CPX_PneuOst_AS17_MPA1G_VMPA1_FB_EMG_8_8DO_1 AT %B4 : BYTE;
		SEW_AS_1_Drive_1x3PD_1 AT %B69 : ARRAY[0..5] OF BYTE;
		Glue_DO_16_bytes_1 AT %B30 : ARRAY[0..15] OF BYTE;
	END_STRUCT;
END_TYPE
