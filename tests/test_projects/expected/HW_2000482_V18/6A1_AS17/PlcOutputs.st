TYPE
	PlcOutputs : STRUCT
		_6A2_AS17_6A5 : WORD;
		_6A2_AS17_6A6 : WORD;
		_6A2_AS17_6A13 : ARRAY[0..31] OF BYTE;
		HousingReader_AS17_Latch_and_Error_Clear_Control_Bits_1 : BYTE;
		HousingReader_AS17_Operation_instruction_Control_Bits_1 : BYTE;
		HousingReader_AS17_Completion_Clear_Control_Bits_1 : BYTE;
		HousingReader_AS17_Parameter_Bank_Number_1 : WORD;
		HousingReader_AS17_User_Data_128Byte_1 : ARRAY[0..129] OF BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_1 : BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_2 : BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_3 : BYTE;
		CPX_PneuOst_AS17_MPA1S_VMPA1_FB_EMS_8_8DO_4 : BYTE;
		CPX_PneuOst_AS17_MPA1G_VMPA1_FB_EMG_8_8DO_1 : BYTE;
		SEW_AS_1_Drive_1x3PD_1 : ARRAY[0..5] OF BYTE;
		Glue_DO_16_bytes_1 : ARRAY[0..15] OF BYTE;
	END_STRUCT;
END_TYPE
