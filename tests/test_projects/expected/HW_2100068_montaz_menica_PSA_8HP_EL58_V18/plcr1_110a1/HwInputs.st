TYPE
	HwInputs : STRUCT
		_310a1_plc_profinet_interface_1_310a1_plc_profinet_interface_1 AT %B5000 : DWORD;
		_310a1_plc_profinet_interface_1_310a1_plc_profinet_interface_1 AT %B5100 : ARRAY[0..63] OF BYTE;
		et200sp_111a1_111A2_DI_16x24_1 AT %B100 : WORD;
		et200sp_111a1_111A3_DI_16x24_2 AT %B102 : WORD;
		et200sp_111a1_111A4_DI_16x24_3 AT %B104 : WORD;
		et200sptc06a_111A2_DI_16x24_1 AT %B380 : WORD;
		et200sptc06a_111A3_DI_16x24_2 AT %B382 : WORD;
		et200sptc10a_111A2_DI_16x24_1 AT %B480 : WORD;
		et200sptc10a_111A3_DI_16x24_2 AT %B482 : WORD;
		mtstc06c_Handshake_and_General_Error_Status_Bits_1 AT %B8000 : BYTE;
		mtstc06c_Completion_Status_Bits_1 AT %B8001 : BYTE;
		mtstc06c_Terminal_Status_Bits_1 AT %B8002 : BYTE;
		mtstc06c_Operation_Result_Status_1 AT %B8004 : ARRAY[0..19] OF BYTE;
		mtstc06c_Read_Data_128Byte_1 AT %B8024 : ARRAY[0..135] OF BYTE;
		mtstc07a_1_Unsigned32_Input_1 AT %B64 : DWORD;
		mtstc07a_64_Bytes_Input_1 AT %B2300 : ARRAY[0..63] OF BYTE;
		mtstc10c_Handshake_and_General_Error_Status_Bits_1 AT %B9000 : BYTE;
		mtstc10c_Completion_Status_Bits_1 AT %B9001 : BYTE;
		mtstc10c_Terminal_Status_Bits_1 AT %B9002 : BYTE;
		mtstc10c_Operation_Result_Status_1 AT %B9004 : ARRAY[0..19] OF BYTE;
		mtstc10c_Read_Data_128Byte_1 AT %B9024 : ARRAY[0..135] OF BYTE;
		vitc04e_EX600_DX_D_1 AT %B250 : WORD;
		vitc04e_EX600_AXA_1 AT %B252 : DWORD;
		vitc06a_EX600_DX_D_1 AT %B350 : WORD;
		vitc06a_EX600_AXA_1 AT %B352 : DWORD;
		vitc10a_EX600_DX_D_1 AT %B450 : WORD;
		vitc10a_EX600_AXA_1 AT %B452 : DWORD;
		mtstc07b_data_1_Unsigned32_Input_1 AT %B68 : DWORD;
		mtstc07b_data_64_Bytes_Input_1 AT %B3000 : ARRAY[0..63] OF BYTE;
		mtstc07c_1_Unsigned32_Input_1 AT %B72 : DWORD;
		mtstc07c_64_Bytes_Input_1 AT %B2500 : ARRAY[0..63] OF BYTE;
		plc_tc04d_plc_tc04d AT %B2100 : ARRAY[0..63] OF BYTE;
		plc_tc04d_plc_tc04d AT %B0 : ARRAY[0..5] OF BYTE;
		plc_tc04d_plc_tc04d AT %B6 : ARRAY[0..11] OF BYTE;
		plc_tc08_plc_tc08 AT %B2200 : ARRAY[0..63] OF BYTE;
		plc_tc08_plc_tc08 AT %B18 : ARRAY[0..5] OF BYTE;
		plc_tc08_plc_tc08 AT %B24 : ARRAY[0..11] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B2000 : ARRAY[0..63] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B36 : ARRAY[0..5] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B42 : ARRAY[0..11] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B2800 : ARRAY[0..63] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B54 : ARRAY[0..5] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B76 : ARRAY[0..11] OF BYTE;
		plc_tc11_cd_plc_tc11_cd AT %B2900 : ARRAY[0..7] OF BYTE;
		plcr1_110a2_plcr1_110a2 AT %B1400 : ARRAY[0..31] OF BYTE;
		plcr1_110a2_plcr1_110a2 AT %B1500 : ARRAY[0..31] OF BYTE;
		plcr1_110a2_plcr1_110a2 AT %B1600 : ARRAY[0..31] OF BYTE;
		plcr1_110a2_plcr1_110a2 AT %B1700 : ARRAY[0..31] OF BYTE;
		plcr1_110a2_plcr1_110a2 AT %B4000 : ARRAY[0..31] OF BYTE;
		plcr1_110a2_plcr1_110a2 AT %B1800 : ARRAY[0..31] OF BYTE;
		pnpn_tc11a_FDI_FDO_6Bytes_12Bytes AT %B1900 : ARRAY[0..5] OF BYTE;
		pnpn_tc11a_FDI_FDO_12Bytes_6Bytes AT %B1912 : ARRAY[0..11] OF BYTE;
		pnpn_tc11a_IN_64_Bytes AT %B2600 : ARRAY[0..63] OF BYTE;
		pnpn_tc11a_IN_64_Bytes_1 AT %B2700 : ARRAY[0..63] OF BYTE;
		vitc11f_EX600_DX_D_1 AT %B550 : WORD;
		vitc11f_EX600_AXA_1 AT %B552 : DWORD;
	END_STRUCT;
END_TYPE
