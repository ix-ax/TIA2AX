TYPE
	HwOutputs : STRUCT
		CPX_PneuOst_AS11_MPA1S_VMPA1_FB_EMS_8_8DO_1 AT %B13 : BYTE;
		CPX_PneuOst_AS11_MPA2S_VMPA2_FB_EMS_4_4DO_2 AT %B183 : BYTE;
		CPX_PneuOst_AS11_MPA2S_VMPA2_FB_EMS_4_4DO_1 AT %B193 : BYTE;
		CPX_PneuOst_AS11_MPA1S_VMPA1_FB_EMS_8_8DO_3 AT %B184 : BYTE;
		CPX_PneuOst_AS11_MPA1S_VMPA1_FB_EMS_8_8DO_4 AT %B185 : BYTE;
		CPX_PneuOst_AS11_MPA1G_VMPA1_FB_EMG_8_8DO_1 AT %B186 : BYTE;
		_6A2_AS11_6A5 AT %B0 : WORD;
		_6A2_AS11_6A13 AT %B19 : ARRAY[0..31] OF BYTE;
		_6A2_AS11_6A20 AT %B328 : ARRAY[0..7] OF BYTE;
		HousingReader_AS11_Latch_and_Error_Clear_Control_Bits_1 AT %B6 : BYTE;
		HousingReader_AS11_Operation_instruction_Control_Bits_1 AT %B7 : BYTE;
		HousingReader_AS11_Completion_Clear_Control_Bits_1 AT %B12 : BYTE;
		HousingReader_AS11_Parameter_Bank_Number_1 AT %B51 : WORD;
		HousingReader_AS11_User_Data_128Byte_1 AT %B53 : ARRAY[0..129] OF BYTE;
		CPX_PneuOst_AS10_2_MPA1S_VMPA1_FB_EMS_8_8DO_1 AT %B188 : BYTE;
		CPX_PneuOst_AS10_2_MPA1S_VMPA1_FB_EMS_8_8DO_3 AT %B190 : BYTE;
		CPX_PneuOst_AS10_2_MPA1S_VMPA1_FB_EMS_8_8DO_2 AT %B194 : BYTE;
		CPX_PneuOst_AS10_2_MPA1G_VMPA1_FB_EMG_8_8DO_1 AT %B189 : BYTE;
		FlashingReader_Latch_and_Error_Clear_Control_Bits_1 AT %B191 : BYTE;
		FlashingReader_Operation_instruction_Control_Bits_1 AT %B192 : BYTE;
		FlashingReader_Completion_Clear_Control_Bits_1 AT %B195 : BYTE;
		FlashingReader_Parameter_Bank_Number_1 AT %B196 : WORD;
		FlashingReader_User_Data_128Byte_1 AT %B198 : ARRAY[0..129] OF BYTE;
		AS10_2flashing_Out_64_Byte_1 AT %B523 : ARRAY[0..63] OF BYTE;
	END_STRUCT;
END_TYPE
