TYPE
	PlcInputs : STRUCT
		_6A2_AS11_6A3 : WORD;
		_6A2_AS11_6A13 : ARRAY[0..31] OF BYTE;
		HousingReader_AS11_Handshake_and_General_Error_Status_Bits_1 : BYTE;
		HousingReader_AS11_BUSY_Status_Bits_1 : BYTE;
		HousingReader_AS11_Completion_Status_Bits_1 : BYTE;
		HousingReader_AS11_Error_Status_Bits_1 : BYTE;
		HousingReader_AS11_Terminal_Status_Bits_1 : BYTE;
		HousingReader_AS11_Unstable_Read_Status_Bits_1 : BYTE;
		HousingReader_AS11_Matching_Level_and_Total_Evaluation_Grade_Status_1 : ARRAY[0..7] OF BYTE;
		HousingReader_AS11_Operation_Result_Status_1 : ARRAY[0..19] OF BYTE;
		HousingReader_AS11_Read_Data_128Byte_1 : ARRAY[0..135] OF BYTE;
		as13_lan_as13_lan : BYTE;
		FlashingReader_Handshake_and_General_Error_Status_Bits_1 : BYTE;
		FlashingReader_BUSY_Status_Bits_1 : BYTE;
		FlashingReader_Completion_Status_Bits_1 : BYTE;
		FlashingReader_Error_Status_Bits_1 : BYTE;
		FlashingReader_Terminal_Status_Bits_1 : BYTE;
		FlashingReader_Unstable_Read_Status_Bits_1 : BYTE;
		FlashingReader_Matching_Level_and_Total_Evaluation_Grade_Status_1 : ARRAY[0..7] OF BYTE;
		FlashingReader_Operation_Result_Status_1 : ARRAY[0..19] OF BYTE;
		FlashingReader_Read_Data_128Byte_1 : ARRAY[0..135] OF BYTE;
		AS10_2flashing_In_64_Byte_1 : ARRAY[0..63] OF BYTE;
	END_STRUCT;
END_TYPE
