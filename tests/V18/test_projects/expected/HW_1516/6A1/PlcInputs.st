TYPE
	PlcInputs : STRUCT
		_10A1_Acquisition_Status_1 : ARRAY[0..2] OF BYTE;
		_10A1_Results_Status_1 : BYTE;
		_10A1_Soft_Event_Control_1 : BYTE;
		_10A1_Result_Data_64_bytes_1 : ARRAY[0..71] OF BYTE;
		_11A1_11A2 : BYTE;
		_11A1_11A3 : BYTE;
	END_STRUCT;
END_TYPE
