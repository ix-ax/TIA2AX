TYPE
	HwIdentifiers : WORD
	(
		ST80_PLC_Profilschiene_0 :=	WORD#256,
		ST80_PLC :=	WORD#48,
		ST80_PLC_Card_reader_writer_1 :=	WORD#51,
		ST80_PLC_CPU_display_1 :=	WORD#54,
		ST80_PLC_OPC_UA_1 :=	WORD#117,
		ST80_PLC_DP_interface_1 :=	WORD#60,
		ST80_PLC_PROFINET_interface_1 :=	WORD#64,
		ST80_PLC_PROFINET_interface_1_Port_1 :=	WORD#65,
		ST80_PLC_PROFINET_interface_1_Port_2 :=	WORD#66,
		ST80_PLC_PROFINET_interface_2 :=	WORD#72,
		ST80_PLC_PROFINET_interface_2_Port_1 :=	WORD#73,
		ST80_Switch_SCALANCE_X_rack :=	WORD#412,
		ST80_Switch :=	WORD#413,
		ST80_Switch_ST80_Switch :=	WORD#414,
		ST80_Switch_SCALANCE_interface_1 :=	WORD#415,
		ST80_Switch_SCALANCE_interface_1_Port_1 :=	WORD#416,
		ST80_Switch_SCALANCE_interface_1_Port_2 :=	WORD#417,
		ST80_Switch_SCALANCE_interface_1_Port_3 :=	WORD#418,
		ST80_Switch_SCALANCE_interface_1_Port_4 :=	WORD#419,
		ST80_Switch_SCALANCE_interface_1_Port_5 :=	WORD#420,
		ST80_Switch_SCALANCE_interface_1_Port_6 :=	WORD#421,
		ST80_Switch_SCALANCE_interface_1_Port_7 :=	WORD#422,
		ST80_Switch_SCALANCE_interface_1_Port_8 :=	WORD#423,
		ST80_Switch_SCALANCE_interface_1_Port_9 :=	WORD#424,
		ST80_Switch_SCALANCE_interface_1_Port_10 :=	WORD#425,
		ST80_Switch_SCALANCE_interface_1_Port_11 :=	WORD#426,
		ST80_Switch_SCALANCE_interface_1_Port_12 :=	WORD#427,
		ST80_Switch_SCALANCE_interface_1_Port_13 :=	WORD#428,
		ST80_Switch_SCALANCE_interface_1_Port_14 :=	WORD#429,
		ST80_Switch_SCALANCE_interface_1_Port_15 :=	WORD#430,
		ST80_Switch_SCALANCE_interface_1_Port_16 :=	WORD#431,
		ST80_1_DM260_EB_Box_Rack :=	WORD#270,
		ST80_1_DM260_EB_Box :=	WORD#258,
		ST80_1_DM260_EB_Box_Interface :=	WORD#259,
		ST80_1_DM260_EB_Box_Interface_Port_1 :=	WORD#260,
		ST80_1_DM260_EB_Box_DataMan_260 :=	WORD#261,
		ST80_1_DM260_EB_Box_Acquisition_Control_1 :=	WORD#262,
		ST80_1_DM260_EB_Box_Acquisition_Status_1 :=	WORD#263,
		ST80_1_DM260_EB_Box_Results_Control_1 :=	WORD#264,
		ST80_1_DM260_EB_Box_Results_Status_1 :=	WORD#265,
		ST80_1_DM260_EB_Box_Soft_Event_Control_1 :=	WORD#266,
		ST80_1_DM260_EB_Box_User_Data_64_bytes_1 :=	WORD#267,
		ST80_1_DM260_EB_Box_Result_Data_64_bytes_1 :=	WORD#268,
		ST80_HMI_ConnectionBox_2_Connection_Box :=	WORD#272,
		ST80_HMI_ConnectionBox_2 :=	WORD#273,
		ST80_HMI_ConnectionBox_2_ST80_HMI_ConnectionBox_2 :=	WORD#274,
		ST80_HMI_ConnectionBox_2_SCALANCE_interface_1 :=	WORD#275,
		ST80_HMI_ConnectionBox_2_SCALANCE_interface_1_Port_1 :=	WORD#276,
		ST80_HMI_ConnectionBox_2_SCALANCE_interface_1_Port_2 :=	WORD#277,
		ST80_HMI_ConnectionBox_2_SCALANCE_interface_1_Port_3 :=	WORD#278,
		ST80_1_CMMT_1GF1_PN_IO_Interface :=	WORD#282,
		ST80_1_CMMT_1GF1_PN_IO_Interface_Port_1 :=	WORD#283,
		ST80_1_CMMT_1GF1_PN_IO_Interface_Port_2 :=	WORD#284,
		ST80_1_CMMT_1GF1_CMMT_AS_V1 :=	WORD#285,
		ST80_1_CMMT_1GF1_DO_SERVO_1_Module_Access_Point :=	WORD#287,
		ST80_1_CMMT_1GF1_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 :=	WORD#288,
		ST80_1_CMMT_1GF1_Siemens_telegram_111_PZD_12_12 :=	WORD#288,
		ST80_1_CMMT_1GF2_PN_IO_Interface :=	WORD#292,
		ST80_1_CMMT_1GF2_PN_IO_Interface_Port_1 :=	WORD#293,
		ST80_1_CMMT_1GF2_PN_IO_Interface_Port_2 :=	WORD#294,
		ST80_1_CMMT_1GF2_CMMT_AS_V1 :=	WORD#295,
		ST80_1_CMMT_1GF2_DO_SERVO_1_Module_Access_Point :=	WORD#297,
		ST80_1_CMMT_1GF2_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 :=	WORD#298,
		ST80_1_CMMT_1GF2_Siemens_telegram_111_PZD_12_12 :=	WORD#298,
		ST80_1_DM260_PB_Box_Rack :=	WORD#300,
		ST80_1_DM260_PB_Box :=	WORD#301,
		ST80_1_DM260_PB_Box_Interface :=	WORD#302,
		ST80_1_DM260_PB_Box_Interface_Port_1 :=	WORD#303,
		ST80_1_DM260_PB_Box_DataMan_260 :=	WORD#304,
		ST80_1_DM260_PB_Box_Acquisition_Control_1 :=	WORD#305,
		ST80_1_DM260_PB_Box_Acquisition_Status_1 :=	WORD#306,
		ST80_1_DM260_PB_Box_Results_Control_1 :=	WORD#307,
		ST80_1_DM260_PB_Box_Results_Status_1 :=	WORD#308,
		ST80_1_DM260_PB_Box_Soft_Event_Control_1 :=	WORD#309,
		ST80_1_DM260_PB_Box_User_Data_64_bytes_1 :=	WORD#310,
		ST80_1_DM260_PB_Box_Result_Data_64_bytes_1 :=	WORD#311,
		ST80_ET200SP_2_Rack_0 :=	WORD#313,
		ST80_ET200SP_2 :=	WORD#314,
		ST80_ET200SP_2_ST80_ET200SP_2 :=	WORD#315,
		ST80_ET200SP_2_PROFINET_interface :=	WORD#316,
		ST80_ET200SP_2_PROFINET_interface_Port_1 :=	WORD#318,
		ST80_ET200SP_2_PROFINET_interface_Port_2 :=	WORD#317,
		ST80_ET200SP_2_BA_2xRJ45 :=	WORD#318,
		ST80_ET200SP_2_BU_Cover_15_mm_1 :=	WORD#319,
		ST80_ET200SP_2_11M1 :=	WORD#320,
		ST80_ET200SP_2_11M2 :=	WORD#321,
		ST80_ET200SP_2_11M3 :=	WORD#322,
		ST80_ET200SP_2_11M4 :=	WORD#323,
		ST80_ET200SP_2_12M1 :=	WORD#324,
		ST80_ET200SP_2_12M2 :=	WORD#325,
		ST80_ET200SP_2_12M3 :=	WORD#326,
		ST80_ET200SP_2_12M4 :=	WORD#327,
		ST80_ET200SP_2_13M1 :=	WORD#328,
		ST80_ET200SP_2_13M2 :=	WORD#329,
		ST80_ET200SP_2_13M3 :=	WORD#330,
		ST80_ET200SP_2_13M4 :=	WORD#331,
		ST80_ET200SP_2_Servermodul_1 :=	WORD#332,
		ST80_1_TZ535_PN_Rack :=	WORD#334,
		ST80_1_TZ535_PN :=	WORD#335,
		ST80_1_TZ535_PN_Interface :=	WORD#336,
		ST80_1_TZ535_PN_Interface_Port_1 :=	WORD#337,
		ST80_1_TZ535_PN_Interface_Port_2 :=	WORD#338,
		ST80_1_TZ535_PN_2D_TZ535_PN_PROFINET_IO :=	WORD#339,
		ST80_1_TZ535_PN_In_Out_32_byte_1 :=	WORD#340,
		ST80_1_DM260_Housing_Rack :=	WORD#342,
		ST80_1_DM260_Housing :=	WORD#343,
		ST80_1_DM260_Housing_Interface :=	WORD#344,
		ST80_1_DM260_Housing_Interface_Port_1 :=	WORD#345,
		ST80_1_DM260_Housing_DataMan_260 :=	WORD#346,
		ST80_1_DM260_Housing_Acquisition_Control_1 :=	WORD#347,
		ST80_1_DM260_Housing_Acquisition_Status_1 :=	WORD#348,
		ST80_1_DM260_Housing_Results_Control_1 :=	WORD#349,
		ST80_1_DM260_Housing_Results_Status_1 :=	WORD#350,
		ST80_1_DM260_Housing_Soft_Event_Control_1 :=	WORD#351,
		ST80_1_DM260_Housing_User_Data_64_bytes_1 :=	WORD#352,
		ST80_1_DM260_Housing_Result_Data_64_bytes_1 :=	WORD#353,
		ST80_1_CMMT_3GF1_PN_IO_Interface :=	WORD#357,
		ST80_1_CMMT_3GF1_PN_IO_Interface_Port_1 :=	WORD#358,
		ST80_1_CMMT_3GF1_PN_IO_Interface_Port_2 :=	WORD#359,
		ST80_1_CMMT_3GF1_CMMT_AS_V1 :=	WORD#360,
		ST80_1_CMMT_3GF1_DO_SERVO_1_Module_Access_Point :=	WORD#362,
		ST80_1_CMMT_3GF1_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 :=	WORD#363,
		ST80_1_CMMT_3GF1_Siemens_telegram_111_PZD_12_12 :=	WORD#363,
		ST80_CPX_PN_IO_Interface :=	WORD#367,
		ST80_CPX_PN_IO_Interface_Port_1 :=	WORD#368,
		ST80_CPX_PN_IO_Interface_Port_2 :=	WORD#369,
		ST80_CPX_CPX :=	WORD#370,
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 :=	WORD#371,
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_2 :=	WORD#372,
		ST80_CPX_MPA2S_VMPA2_FB_EMS_4_4DO_1 :=	WORD#373,
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_3 :=	WORD#374,
		ST80_CPX_MPA2S_VMPA2_FB_EMS_4_4DO_2 :=	WORD#375,
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_4 :=	WORD#376,
		ST80_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_5 :=	WORD#377,
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_1 :=	WORD#378,
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_2 :=	WORD#379,
		ST80_CPX_MPA2G_VMPA2_FB_EMG_4_4DO_1 :=	WORD#380,
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_3 :=	WORD#381,
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_4 :=	WORD#382,
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_5 :=	WORD#383,
		ST80_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_6 :=	WORD#384,
		ST80_ET200SP_Rack_0 :=	WORD#386,
		ST80_ET200SP :=	WORD#387,
		ST80_ET200SP_ST80_ET200SP :=	WORD#388,
		ST80_ET200SP_PROFINET_interface :=	WORD#389,
		ST80_ET200SP_PROFINET_interface_Port_1 :=	WORD#391,
		ST80_ET200SP_PROFINET_interface_Port_2 :=	WORD#390,
		ST80_ET200SP_BA_2xRJ45 :=	WORD#391,
		ST80_ET200SP_CM_4xIO_Link_1 :=	WORD#392,
		ST80_ET200SP_CM_4xIO_Link_2 :=	WORD#393,
		ST80_ET200SP_CM_4xIO_Link_3 :=	WORD#394,
		ST80_ET200SP_DI_16x24VDC_ST_1 :=	WORD#395,
		ST80_ET200SP_DI_16x24VDC_ST_2 :=	WORD#396,
		ST80_ET200SP_DI_16x24VDC_ST_3 :=	WORD#397,
		ST80_ET200SP_DI_16x24VDC_ST_4 :=	WORD#398,
		ST80_ET200SP_DQ_16x24VDC_0_5A_ST_1 :=	WORD#399,
		ST80_ET200SP_DQ_16x24VDC_0_5A_ST_2 :=	WORD#400,
		ST80_ET200SP_DQ_16x24VDC_0_5A_ST_3 :=	WORD#401,
		ST80_ET200SP_Servermodul_1 :=	WORD#402,
		ST80_HMI_ConnectionBox_Connection_Box :=	WORD#404,
		ST80_HMI_ConnectionBox :=	WORD#405,
		ST80_HMI_ConnectionBox_ST80_HMI_ConnectionBox :=	WORD#406,
		ST80_HMI_ConnectionBox_SCALANCE_interface_1 :=	WORD#407,
		ST80_HMI_ConnectionBox_SCALANCE_interface_1_Port_1 :=	WORD#408,
		ST80_HMI_ConnectionBox_SCALANCE_interface_1_Port_2 :=	WORD#409,
		ST80_HMI_ConnectionBox_SCALANCE_interface_1_Port_3 :=	WORD#410,
		NONE:= WORD#0
	);
END_TYPE