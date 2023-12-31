TYPE
	HwOutputs : STRUCT
		ST40_2_DM260_Acquisition_Control_1 AT %B2500 : BYTE;
		ST40_2_DM260_Results_Control_1 AT %B2503 : BYTE;
		ST40_2_DM260_Soft_Event_Control_1 AT %B2504 : BYTE;
		ST40_2_DM260_User_Data_64_bytes_1 AT %B2510 : ARRAY[0..67] OF BYTE;
		ST40_3_DM260_Acquisition_Control_1 AT %B3500 : BYTE;
		ST40_3_DM260_Results_Control_1 AT %B3503 : BYTE;
		ST40_3_DM260_Soft_Event_Control_1 AT %B3504 : BYTE;
		ST40_3_DM260_User_Data_64_bytes_1 AT %B3510 : ARRAY[0..67] OF BYTE;
		ST40_1_DM260_Acquisition_Control_1 AT %B1600 : BYTE;
		ST40_1_DM260_Results_Control_1 AT %B1603 : BYTE;
		ST40_1_DM260_Soft_Event_Control_1 AT %B1604 : BYTE;
		ST40_1_DM260_User_Data_64_bytes_1 AT %B1610 : ARRAY[0..67] OF BYTE;
		ST40_2_Promess_Menu_30_33_Out_1 AT %B2100 : WORD;
		ST40_2_Promess_Menu_30_34_Out_1 AT %B2102 : WORD;
		ST40_2_Promess_Menu_30_35_Out_1 AT %B2104 : WORD;
		ST40_2_Promess_Menu_30_36_Out_1 AT %B2106 : WORD;
		ST40_2_Promess_Menu_30_37_Out_1 AT %B2108 : WORD;
		ST40_2_Promess_Menu_30_38_Out_1 AT %B2110 : WORD;
		ST40_2_Promess_Menu_30_39_Out_1 AT %B2112 : WORD;
		ST40_2_Promess_Menu_30_40_Out_1 AT %B2114 : WORD;
		ST40_2_Promess_Menu_30_41_Out_1 AT %B2116 : WORD;
		ST40_2_Promess_Menu_30_42_Out_1 AT %B2118 : WORD;
		ST40_2_Promess_Menu_30_43_Out_1 AT %B2120 : WORD;
		ST40_2_Promess_Menu_30_44_Out_1 AT %B2122 : WORD;
		ST40_2_Promess_Menu_30_45_Out_1 AT %B2124 : WORD;
		ST40_2_Promess_Menu_30_46_Out_1 AT %B2126 : WORD;
		ST40_2_Promess_Menu_30_47_Out_1 AT %B2128 : WORD;
		ST40_2_Promess_Menu_30_48_Out_1 AT %B2130 : WORD;
		ST40_2_Promess_Menu_30_49_Out_1 AT %B2132 : WORD;
		ST40_2_Promess_Menu_30_50_Out_1 AT %B2134 : WORD;
		ST40_2_Promess_Menu_30_51_Out_1 AT %B2136 : WORD;
		ST40_2_Promess_Menu_30_52_Out_1 AT %B2138 : WORD;
		ST40_2_Promess_Menu_30_53_Out_1 AT %B2140 : WORD;
		ST40_2_Promess_Menu_30_54_Out_1 AT %B2142 : WORD;
		ST40_2_Promess_Menu_30_55_Out_1 AT %B2144 : WORD;
		ST40_2_Promess_Menu_30_56_Out_1 AT %B2146 : WORD;
		ST40_2_Promess_Menu_30_57_Out_1 AT %B2148 : WORD;
		ST40_2_Promess_Menu_30_58_Out_1 AT %B2150 : WORD;
		ST40_2_Promess_Menu_30_59_Out_1 AT %B2152 : WORD;
		ST40_2_Promess_Menu_30_60_Out_1 AT %B2154 : WORD;
		ST40_2_Promess_Menu_30_61_Out_1 AT %B2156 : WORD;
		ST40_2_Promess_Menu_30_62_Out_1 AT %B2158 : WORD;
		ST40_2_Promess_Menu_30_63_Out_1 AT %B2160 : WORD;
		ST40_2_Promess_Menu_30_64_Out_1 AT %B2162 : WORD;
		ST40_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 AT %B200 : BYTE;
		ST40_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_2 AT %B201 : BYTE;
		ST40_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_3 AT %B202 : BYTE;
		ST40_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_1 AT %B203 : BYTE;
		ST40_ET200SP_CM_4xIO_Link_1 AT %B100 : ARRAY[0..31] OF BYTE;
		ST40_ET200SP_CM_4xIO_Link_2 AT %B132 : ARRAY[0..31] OF BYTE;
		ST40_ET200SP_DQ_16x24VDC_0_5A_ST_1 AT %B0 : WORD;
		ST40_ET200SP_DQ_8x24VDC_0_5A_ST_2 AT %B2 : BYTE;
		ST40_ET200SP_DQ_8x24VDC_0_5A_ST_3 AT %B3 : BYTE;
	END_STRUCT;
END_TYPE
