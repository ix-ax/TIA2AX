TYPE
	PlcInputs : STRUCT
		CMMT_AS17_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 : ARRAY[0..23] OF BYTE;
		_6A2_AS17_6A3 : WORD;
		_6A2_AS17_6A4 : WORD;
		_6A2_AS17_6A13 : ARRAY[0..31] OF BYTE;
		_6A2_AS17_6A20 : ARRAY[0..7] OF BYTE;
		HousingReader_AS17_Handshake_and_General_Error_Status_Bits_1 : BYTE;
		HousingReader_AS17_BUSY_Status_Bits_1 : BYTE;
		HousingReader_AS17_Completion_Status_Bits_1 : BYTE;
		HousingReader_AS17_Error_Status_Bits_1 : BYTE;
		HousingReader_AS17_Terminal_Status_Bits_1 : BYTE;
		HousingReader_AS17_Unstable_Read_Status_Bits_1 : BYTE;
		HousingReader_AS17_Matching_Level_and_Total_Evaluation_Grade_Status_1 : ARRAY[0..7] OF BYTE;
		HousingReader_AS17_Operation_Result_Status_1 : ARRAY[0..19] OF BYTE;
		HousingReader_AS17_Read_Data_128Byte_1 : ARRAY[0..135] OF BYTE;
		SEW_AS_1_Drive_1x3PD_1 : ARRAY[0..5] OF BYTE;
		Glue_DI_16_bytes_1 : ARRAY[0..15] OF BYTE;
		wp12_wp12 : BYTE;
	END_STRUCT;
END_TYPE
