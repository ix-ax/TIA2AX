TYPE
	HwInputs : STRUCT
		_6A2_AS11_6A3 AT %B0 : WORD;
		_6A2_AS11_6A13 AT %B19 : ARRAY[0..31] OF BYTE;
		HousingReader_AS11_Handshake_and_General_Error_Status_Bits_1 AT %B51 : BYTE;
		HousingReader_AS11_BUSY_Status_Bits_1 AT %B52 : BYTE;
		HousingReader_AS11_Completion_Status_Bits_1 AT %B53 : BYTE;
		HousingReader_AS11_Error_Status_Bits_1 AT %B54 : BYTE;
		HousingReader_AS11_Terminal_Status_Bits_1 AT %B55 : BYTE;
		HousingReader_AS11_Unstable_Read_Status_Bits_1 AT %B56 : BYTE;
		HousingReader_AS11_Matching_Level_and_Total_Evaluation_Grade_Status_1 AT %B57 : ARRAY[0..7] OF BYTE;
		HousingReader_AS11_Operation_Result_Status_1 AT %B65 : ARRAY[0..19] OF BYTE;
		HousingReader_AS11_Read_Data_128Byte_1 AT %B85 : ARRAY[0..135] OF BYTE;
		as13_lan_as13_lan AT %B221 : BYTE;
		FlashingReader_Handshake_and_General_Error_Status_Bits_1 AT %B222 : BYTE;
		FlashingReader_BUSY_Status_Bits_1 AT %B223 : BYTE;
		FlashingReader_Completion_Status_Bits_1 AT %B224 : BYTE;
		FlashingReader_Error_Status_Bits_1 AT %B225 : BYTE;
		FlashingReader_Terminal_Status_Bits_1 AT %B226 : BYTE;
		FlashingReader_Unstable_Read_Status_Bits_1 AT %B227 : BYTE;
		FlashingReader_Matching_Level_and_Total_Evaluation_Grade_Status_1 AT %B228 : ARRAY[0..7] OF BYTE;
		FlashingReader_Operation_Result_Status_1 AT %B236 : ARRAY[0..19] OF BYTE;
		FlashingReader_Read_Data_128Byte_1 AT %B256 : ARRAY[0..135] OF BYTE;
		AS10_2flashing_In_64_Byte_1 AT %B528 : ARRAY[0..63] OF BYTE;
	END_STRUCT;
END_TYPE
