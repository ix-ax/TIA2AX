TYPE
	HwIdentifiers : WORD
	(
		ST70_PLC_Profilschiene_0 :=	WORD#256,
		ST70_PLC :=	WORD#48,
		ST70_PLC_Card_reader_writer_1 :=	WORD#51,
		ST70_PLC_CPU_display_1 :=	WORD#54,
		ST70_PLC_OPC_UA_1 :=	WORD#117,
		ST70_PLC_DP_interface_1 :=	WORD#60,
		ST70_PLC_PROFINET_interface_1 :=	WORD#64,
		ST70_PLC_PROFINET_interface_1_Port_1 :=	WORD#65,
		ST70_PLC_PROFINET_interface_1_Port_2 :=	WORD#66,
		ST70_PLC_PROFINET_interface_2 :=	WORD#72,
		ST70_PLC_PROFINET_interface_2_Port_1 :=	WORD#73,
		ST70_Switch_SCALANCE_X_rack :=	WORD#406,
		ST70_Switch :=	WORD#407,
		ST70_Switch_ST70_Switch :=	WORD#408,
		ST70_Switch_SCALANCE_interface_1 :=	WORD#409,
		ST70_Switch_SCALANCE_interface_1_Port_1 :=	WORD#410,
		ST70_Switch_SCALANCE_interface_1_Port_2 :=	WORD#411,
		ST70_Switch_SCALANCE_interface_1_Port_3 :=	WORD#412,
		ST70_Switch_SCALANCE_interface_1_Port_4 :=	WORD#413,
		ST70_Switch_SCALANCE_interface_1_Port_5 :=	WORD#414,
		ST70_Switch_SCALANCE_interface_1_Port_6 :=	WORD#415,
		ST70_Switch_SCALANCE_interface_1_Port_7 :=	WORD#416,
		ST70_Switch_SCALANCE_interface_1_Port_8 :=	WORD#417,
		ST70_Switch_SCALANCE_interface_1_Port_9 :=	WORD#418,
		ST70_Switch_SCALANCE_interface_1_Port_10 :=	WORD#419,
		ST70_Switch_SCALANCE_interface_1_Port_11 :=	WORD#420,
		ST70_Switch_SCALANCE_interface_1_Port_12 :=	WORD#421,
		ST70_Switch_SCALANCE_interface_1_Port_13 :=	WORD#422,
		ST70_Switch_SCALANCE_interface_1_Port_14 :=	WORD#423,
		ST70_Switch_SCALANCE_interface_1_Port_15 :=	WORD#424,
		ST70_Switch_SCALANCE_interface_1_Port_16 :=	WORD#425,
		ST70_HMI_ConnectionBox_Connection_Box :=	WORD#265,
		ST70_HMI_ConnectionBox :=	WORD#258,
		ST70_HMI_ConnectionBox_ST70_HMI_ConnectionBox :=	WORD#259,
		ST70_HMI_ConnectionBox_SCALANCE_interface_1 :=	WORD#260,
		ST70_HMI_ConnectionBox_SCALANCE_interface_1_Port_1 :=	WORD#261,
		ST70_HMI_ConnectionBox_SCALANCE_interface_1_Port_2 :=	WORD#262,
		ST70_HMI_ConnectionBox_SCALANCE_interface_1_Port_3 :=	WORD#263,
		ST70_ET200SP_Rack_0 :=	WORD#272,
		ST70_ET200SP :=	WORD#273,
		ST70_ET200SP_ST70_ET200SP :=	WORD#274,
		ST70_ET200SP_PROFINET_interface :=	WORD#275,
		ST70_ET200SP_PROFINET_interface_Port_1 :=	WORD#277,
		ST70_ET200SP_PROFINET_interface_Port_2 :=	WORD#276,
		ST70_ET200SP_BA_2xRJ45 :=	WORD#277,
		ST70_ET200SP_CM_4xIO_Link_1 :=	WORD#278,
		ST70_ET200SP_DI_16x24VDC_ST_1 :=	WORD#279,
		ST70_ET200SP_DI_16x24VDC_ST_2 :=	WORD#280,
		ST70_ET200SP_DI_8x24VDC_ST_3 :=	WORD#281,
		ST70_ET200SP_DI_16x24VDC_ST_4 :=	WORD#266,
		ST70_ET200SP_DQ_16x24VDC_0_5A_ST_1 :=	WORD#267,
		ST70_ET200SP_DQ_16x24VDC_0_5A_ST_2 :=	WORD#268,
		ST70_ET200SP_DQ_16x24VDC_0_5A_ST_3 :=	WORD#269,
		ST70_ET200SP_Servermodul_1 :=	WORD#270,
		ST70_CPX_PN_IO_Interface :=	WORD#285,
		ST70_CPX_PN_IO_Interface_Port_1 :=	WORD#286,
		ST70_CPX_PN_IO_Interface_Port_2 :=	WORD#287,
		ST70_CPX_CPX :=	WORD#288,
		ST70_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 :=	WORD#289,
		ST70_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_2 :=	WORD#290,
		ST70_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_3 :=	WORD#291,
		ST70_CPX_MPA2S_VMPA2_FB_EMS_4_4DO_1 :=	WORD#292,
		ST70_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_3 :=	WORD#293,
		ST70_1_DM260_PB_Rack :=	WORD#295,
		ST70_1_DM260_PB :=	WORD#296,
		ST70_1_DM260_PB_Interface :=	WORD#297,
		ST70_1_DM260_PB_Interface_Port_1 :=	WORD#298,
		ST70_1_DM260_PB_DataMan_260 :=	WORD#299,
		ST70_1_DM260_PB_Acquisition_Control_1 :=	WORD#300,
		ST70_1_DM260_PB_Acquisition_Status_1 :=	WORD#301,
		ST70_1_DM260_PB_Results_Control_1 :=	WORD#302,
		ST70_1_DM260_PB_Results_Status_1 :=	WORD#303,
		ST70_1_DM260_PB_Soft_Event_Control_1 :=	WORD#304,
		ST70_1_DM260_PB_User_Data_64_bytes_1 :=	WORD#305,
		ST70_1_DM260_PB_Result_Data_64_bytes_1 :=	WORD#306,
		ST70_2_DM260_PB_Rack :=	WORD#308,
		ST70_2_DM260_PB :=	WORD#309,
		ST70_2_DM260_PB_Interface :=	WORD#310,
		ST70_2_DM260_PB_Interface_Port_1 :=	WORD#311,
		ST70_2_DM260_PB_DataMan_260 :=	WORD#312,
		ST70_2_DM260_PB_Acquisition_Control_1 :=	WORD#313,
		ST70_2_DM260_PB_Acquisition_Status_1 :=	WORD#314,
		ST70_2_DM260_PB_Results_Control_1 :=	WORD#315,
		ST70_2_DM260_PB_Results_Status_1 :=	WORD#316,
		ST70_2_DM260_PB_Soft_Event_Control_1 :=	WORD#317,
		ST70_2_DM260_PB_User_Data_64_bytes_1 :=	WORD#318,
		ST70_2_DM260_PB_Result_Data_64_bytes_1 :=	WORD#319,
		ST70_1_CMMT_3GF1_PN_IO_Interface :=	WORD#323,
		ST70_1_CMMT_3GF1_PN_IO_Interface_Port_1 :=	WORD#324,
		ST70_1_CMMT_3GF1_PN_IO_Interface_Port_2 :=	WORD#325,
		ST70_1_CMMT_3GF1_CMMT_AS_V1 :=	WORD#326,
		ST70_1_CMMT_3GF1_DO_SERVO_1_Module_Access_Point :=	WORD#328,
		ST70_1_CMMT_3GF1_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 :=	WORD#329,
		ST70_1_CMMT_3GF1_Siemens_telegram_111_PZD_12_12 :=	WORD#329,
		ST70_1_CMMT_3GF2_PN_IO_Interface :=	WORD#333,
		ST70_1_CMMT_3GF2_PN_IO_Interface_Port_1 :=	WORD#334,
		ST70_1_CMMT_3GF2_PN_IO_Interface_Port_2 :=	WORD#335,
		ST70_1_CMMT_3GF2_CMMT_AS_V1 :=	WORD#336,
		ST70_1_CMMT_3GF2_DO_SERVO_1_Module_Access_Point :=	WORD#338,
		ST70_1_CMMT_3GF2_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 :=	WORD#339,
		ST70_1_CMMT_3GF2_Siemens_telegram_111_PZD_12_12 :=	WORD#339,
		ST70_3_DM260_PB_Rack :=	WORD#341,
		ST70_3_DM260_PB :=	WORD#342,
		ST70_3_DM260_PB_Interface :=	WORD#343,
		ST70_3_DM260_PB_Interface_Port_1 :=	WORD#344,
		ST70_3_DM260_PB_DataMan_260 :=	WORD#345,
		ST70_3_DM260_PB_Acquisition_Control_1 :=	WORD#346,
		ST70_3_DM260_PB_Acquisition_Status_1 :=	WORD#347,
		ST70_3_DM260_PB_Results_Control_1 :=	WORD#348,
		ST70_3_DM260_PB_Results_Status_1 :=	WORD#349,
		ST70_3_DM260_PB_Soft_Event_Control_1 :=	WORD#350,
		ST70_3_DM260_PB_User_Data_64_bytes_1 :=	WORD#351,
		ST70_3_DM260_PB_Result_Data_64_bytes_1 :=	WORD#352,
		ST70_1_DM260_EB_Rack :=	WORD#354,
		ST70_1_DM260_EB :=	WORD#355,
		ST70_1_DM260_EB_Interface :=	WORD#356,
		ST70_1_DM260_EB_Interface_Port_1 :=	WORD#357,
		ST70_1_DM260_EB_DataMan_260 :=	WORD#358,
		ST70_1_DM260_EB_Acquisition_Control_1 :=	WORD#359,
		ST70_1_DM260_EB_Acquisition_Status_1 :=	WORD#360,
		ST70_1_DM260_EB_Results_Control_1 :=	WORD#361,
		ST70_1_DM260_EB_Results_Status_1 :=	WORD#362,
		ST70_1_DM260_EB_Soft_Event_Control_1 :=	WORD#363,
		ST70_1_DM260_EB_User_Data_64_bytes_1 :=	WORD#364,
		ST70_1_DM260_EB_Result_Data_64_bytes_1 :=	WORD#365,
		ST70_2_DM260_EB_Rack :=	WORD#367,
		ST70_2_DM260_EB :=	WORD#368,
		ST70_2_DM260_EB_Interface :=	WORD#369,
		ST70_2_DM260_EB_Interface_Port_1 :=	WORD#370,
		ST70_2_DM260_EB_DataMan_260 :=	WORD#371,
		ST70_2_DM260_EB_Acquisition_Control_1 :=	WORD#372,
		ST70_2_DM260_EB_Acquisition_Status_1 :=	WORD#373,
		ST70_2_DM260_EB_Results_Control_1 :=	WORD#374,
		ST70_2_DM260_EB_Results_Status_1 :=	WORD#375,
		ST70_2_DM260_EB_Soft_Event_Control_1 :=	WORD#376,
		ST70_2_DM260_EB_User_Data_64_bytes_1 :=	WORD#377,
		ST70_2_DM260_EB_Result_Data_64_bytes_1 :=	WORD#378,
		ST70_3_DM260_EB_Rack :=	WORD#380,
		ST70_3_DM260_EB :=	WORD#381,
		ST70_3_DM260_EB_Interface :=	WORD#382,
		ST70_3_DM260_EB_Interface_Port_1 :=	WORD#383,
		ST70_3_DM260_EB_DataMan_260 :=	WORD#384,
		ST70_3_DM260_EB_Acquisition_Control_1 :=	WORD#385,
		ST70_3_DM260_EB_Acquisition_Status_1 :=	WORD#386,
		ST70_3_DM260_EB_Results_Control_1 :=	WORD#387,
		ST70_3_DM260_EB_Results_Status_1 :=	WORD#388,
		ST70_3_DM260_EB_Soft_Event_Control_1 :=	WORD#389,
		ST70_3_DM260_EB_User_Data_64_bytes_1 :=	WORD#390,
		ST70_3_DM260_EB_Result_Data_64_bytes_1 :=	WORD#391,
		ST70_1_CMMT_3GF3_PN_IO_Interface :=	WORD#395,
		ST70_1_CMMT_3GF3_PN_IO_Interface_Port_1 :=	WORD#396,
		ST70_1_CMMT_3GF3_PN_IO_Interface_Port_2 :=	WORD#397,
		ST70_1_CMMT_3GF3_CMMT_AS_V1 :=	WORD#398,
		ST70_1_CMMT_3GF3_DO_SERVO_1_Module_Access_Point :=	WORD#400,
		ST70_1_CMMT_3GF3_DO_SERVO_1_Siemens_telegram_111_PZD_12_12 :=	WORD#401,
		ST70_1_CMMT_3GF3_Siemens_telegram_111_PZD_12_12 :=	WORD#401,
		NONE:= WORD#0
	);
END_TYPE