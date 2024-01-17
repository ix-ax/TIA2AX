TYPE
	HwOutputs : STRUCT
		_6A1_6A4 AT %B1000 : ARRAY[0..7] OF BYTE;
		_10A1_Acquisition_Control_1 AT %B300 : BYTE;
		_10A1_Results_Control_1 AT %B303 : BYTE;
		_10A1_Soft_Event_Control_1 AT %B304 : BYTE;
		_10A1_User_Data_64_bytes_1 AT %B310 : ARRAY[0..67] OF BYTE;
		_11A1_11A4 AT %B100 : BYTE;
		_12A1_12A4 AT %B1100 : WORD;
	END_STRUCT;
END_TYPE
