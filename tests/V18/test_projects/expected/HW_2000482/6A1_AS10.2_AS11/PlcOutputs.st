TYPE
	PlcOutputs : STRUCT
		CPX_PneuOst_AS11_MPA1S_VMPA1_FB_EMS_8_8DO_1 : BYTE;
		CPX_PneuOst_AS11_MPA2S_VMPA2_FB_EMS_4_4DO_2 : BYTE;
		CPX_PneuOst_AS11_MPA2S_VMPA2_FB_EMS_4_4DO_1 : BYTE;
		CPX_PneuOst_AS11_MPA1S_VMPA1_FB_EMS_8_8DO_3 : BYTE;
		CPX_PneuOst_AS11_MPA1S_VMPA1_FB_EMS_8_8DO_4 : BYTE;
		CPX_PneuOst_AS11_MPA1G_VMPA1_FB_EMG_8_8DO_1 : BYTE;
		_6A2_AS11_6A5 : WORD;
		_6A2_AS11_6A13 : ARRAY[0..31] OF BYTE;
		_6A2_AS11_6A20 : ARRAY[0..7] OF BYTE;
		HousingReader_AS11_Latch_and_Error_Clear_Control_Bits_1 : BYTE;
		HousingReader_AS11_Operation_instruction_Control_Bits_1 : BYTE;
		HousingReader_AS11_Completion_Clear_Control_Bits_1 : BYTE;
		HousingReader_AS11_Parameter_Bank_Number_1 : WORD;
		HousingReader_AS11_User_Data_128Byte_1 : ARRAY[0..129] OF BYTE;
		CPX_PneuOst_AS10_2_MPA1S_VMPA1_FB_EMS_8_8DO_1 : BYTE;
		CPX_PneuOst_AS10_2_MPA1S_VMPA1_FB_EMS_8_8DO_3 : BYTE;
		CPX_PneuOst_AS10_2_MPA1S_VMPA1_FB_EMS_8_8DO_2 : BYTE;
		CPX_PneuOst_AS10_2_MPA1G_VMPA1_FB_EMG_8_8DO_1 : BYTE;
		FlashingReader_Latch_and_Error_Clear_Control_Bits_1 : BYTE;
		FlashingReader_Operation_instruction_Control_Bits_1 : BYTE;
		FlashingReader_Completion_Clear_Control_Bits_1 : BYTE;
		FlashingReader_Parameter_Bank_Number_1 : WORD;
		FlashingReader_User_Data_128Byte_1 : ARRAY[0..129] OF BYTE;
		AS10_2flashing_Out_64_Byte_1 : ARRAY[0..63] OF BYTE;
	END_STRUCT;
END_TYPE
