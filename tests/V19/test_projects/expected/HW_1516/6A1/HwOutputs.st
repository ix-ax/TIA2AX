TYPE
	HwOutputs : STRUCT
		_10A1_Acquisition_Control_1 AT %B300 : BYTE;
		_10A1_Results_Control_1 AT %B303 : BYTE;
		_10A1_Soft_Event_Control_1 AT %B304 : BYTE;
		_10A1_User_Data_64_bytes_1 AT %B310 : ARRAY[0..67] OF BYTE;
		_11A1_11A4 AT %B100 : BYTE;
	END_STRUCT;
END_TYPE
