TYPE
	HwIdentifiers : WORD
	(
		ST50_PLC_Profilschiene_0 :=	WORD#256,
		ST50_PLC :=	WORD#48,
		ST50_PLC_Card_reader_writer_1 :=	WORD#51,
		ST50_PLC_CPU_display_1 :=	WORD#54,
		ST50_PLC_OPC_UA_1 :=	WORD#117,
		ST50_PLC_DP_interface_1 :=	WORD#60,
		ST50_PLC_PROFINET_interface_1 :=	WORD#64,
		ST50_PLC_PROFINET_interface_1_Port_1 :=	WORD#65,
		ST50_PLC_PROFINET_interface_1_Port_2 :=	WORD#66,
		ST50_PLC_PROFINET_interface_2 :=	WORD#72,
		ST50_PLC_PROFINET_interface_2_Port_1 :=	WORD#73,
		ST50_Switch_SCALANCE_X_rack :=	WORD#393,
		ST50_Switch :=	WORD#394,
		ST50_Switch_ST50_Switch :=	WORD#395,
		ST50_Switch_SCALANCE_interface_1 :=	WORD#396,
		ST50_Switch_SCALANCE_interface_1_Port_1 :=	WORD#397,
		ST50_Switch_SCALANCE_interface_1_Port_2 :=	WORD#398,
		ST50_Switch_SCALANCE_interface_1_Port_3 :=	WORD#399,
		ST50_Switch_SCALANCE_interface_1_Port_4 :=	WORD#400,
		ST50_Switch_SCALANCE_interface_1_Port_5 :=	WORD#401,
		ST50_Switch_SCALANCE_interface_1_Port_6 :=	WORD#402,
		ST50_Switch_SCALANCE_interface_1_Port_7 :=	WORD#403,
		ST50_Switch_SCALANCE_interface_1_Port_8 :=	WORD#404,
		ST50_Switch_SCALANCE_interface_1_Port_9 :=	WORD#405,
		ST50_Switch_SCALANCE_interface_1_Port_10 :=	WORD#406,
		ST50_Switch_SCALANCE_interface_1_Port_11 :=	WORD#407,
		ST50_Switch_SCALANCE_interface_1_Port_12 :=	WORD#408,
		ST50_Switch_SCALANCE_interface_1_Port_13 :=	WORD#409,
		ST50_Switch_SCALANCE_interface_1_Port_14 :=	WORD#410,
		ST50_Switch_SCALANCE_interface_1_Port_15 :=	WORD#411,
		ST50_Switch_SCALANCE_interface_1_Port_16 :=	WORD#412,
		ST50_Switch_1_SCALANCE_X_rack :=	WORD#416,
		ST50_Switch_1 :=	WORD#417,
		ST50_Switch_1_ST50_Switch_1 :=	WORD#418,
		ST50_Switch_1_SCALANCE_interface_1 :=	WORD#419,
		ST50_Switch_1_SCALANCE_interface_1_Port_1 :=	WORD#420,
		ST50_Switch_1_SCALANCE_interface_1_Port_2 :=	WORD#421,
		ST50_Switch_1_SCALANCE_interface_1_Port_3 :=	WORD#422,
		ST50_Switch_1_SCALANCE_interface_1_Port_4 :=	WORD#423,
		ST50_Switch_1_SCALANCE_interface_1_Port_5 :=	WORD#424,
		ST50_Switch_1_SCALANCE_interface_1_Port_6 :=	WORD#425,
		ST50_Switch_1_SCALANCE_interface_1_Port_7 :=	WORD#426,
		ST50_Switch_1_SCALANCE_interface_1_Port_8 :=	WORD#427,
		ST50_Switch_1_SCALANCE_interface_1_Port_9 :=	WORD#428,
		ST50_Switch_1_SCALANCE_interface_1_Port_10 :=	WORD#429,
		ST50_Switch_1_SCALANCE_interface_1_Port_11 :=	WORD#430,
		ST50_Switch_1_SCALANCE_interface_1_Port_12 :=	WORD#431,
		ST50_Switch_1_SCALANCE_interface_1_Port_13 :=	WORD#432,
		ST50_Switch_1_SCALANCE_interface_1_Port_14 :=	WORD#433,
		ST50_Switch_1_SCALANCE_interface_1_Port_15 :=	WORD#434,
		ST50_Switch_1_SCALANCE_interface_1_Port_16 :=	WORD#435,
		ST50_CPX_PN_IO_Interface :=	WORD#259,
		ST50_CPX_PN_IO_Interface_Port_1 :=	WORD#260,
		ST50_CPX_PN_IO_Interface_Port_2 :=	WORD#261,
		ST50_CPX_CPX :=	WORD#262,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_1 :=	WORD#263,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_2 :=	WORD#264,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_3 :=	WORD#265,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_4 :=	WORD#266,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_5 :=	WORD#267,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_6 :=	WORD#268,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_7 :=	WORD#269,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_8 :=	WORD#270,
		ST50_CPX_MPA1S_VMPA1_FB_EMS_8_8DO_9 :=	WORD#271,
		ST50_CPX_MPA1G_VMPA1_FB_EMG_8_8DO_6 :=	WORD#272,
		ST50_ET200SP_Rack_0 :=	WORD#277,
		ST50_ET200SP :=	WORD#278,
		ST50_ET200SP_ST50_ET200SP :=	WORD#279,
		ST50_ET200SP_PROFINET_interface :=	WORD#280,
		ST50_ET200SP_PROFINET_interface_Port_1 :=	WORD#282,
		ST50_ET200SP_PROFINET_interface_Port_2 :=	WORD#281,
		ST50_ET200SP_BA_2xRJ45 :=	WORD#282,
		ST50_ET200SP_CM_4xIO_Link_1 :=	WORD#283,
		ST50_ET200SP_CM_4xIO_Link_2 :=	WORD#284,
		ST50_ET200SP_DI_16x24VDC_ST_1 :=	WORD#285,
		ST50_ET200SP_DI_16x24VDC_ST_2 :=	WORD#286,
		ST50_ET200SP_DI_8x24VDC_ST_4 :=	WORD#287,
		ST50_ET200SP_DI_8x24VDC_ST_3 :=	WORD#288,
		ST50_ET200SP_DQ_16x24VDC_0_5A_ST_1 :=	WORD#289,
		ST50_ET200SP_DQ_16x24VDC_0_5A_ST_2 :=	WORD#290,
		ST50_ET200SP_DQ_16x24VDC_0_5A_ST_3 :=	WORD#291,
		ST50_ET200SP_Servermodul_1 :=	WORD#292,
		ST50_HMI_ConnectionBox_Connection_Box :=	WORD#294,
		ST50_HMI_ConnectionBox :=	WORD#295,
		ST50_HMI_ConnectionBox_ST50_HMI_ConnectionBox :=	WORD#296,
		ST50_HMI_ConnectionBox_SCALANCE_interface_1 :=	WORD#297,
		ST50_HMI_ConnectionBox_SCALANCE_interface_1_Port_1 :=	WORD#298,
		ST50_HMI_ConnectionBox_SCALANCE_interface_1_Port_2 :=	WORD#299,
		ST50_HMI_ConnectionBox_SCALANCE_interface_1_Port_3 :=	WORD#300,
		ST50_SCHUNK_L_Rack :=	WORD#302,
		ST50_SCHUNK_L :=	WORD#303,
		ST50_SCHUNK_L_Interface :=	WORD#304,
		ST50_SCHUNK_L_Interface_Port_1 :=	WORD#305,
		ST50_SCHUNK_L_Interface_Port_2 :=	WORD#306,
		ST50_SCHUNK_L_DEVICE_SFP :=	WORD#307,
		ST50_SCHUNK_L_IN_4_Double_Words :=	WORD#308,
		ST50_SCHUNK_L_OUT_4_Double_Words :=	WORD#309,
		ST50_SCHUNK_R_Rack :=	WORD#311,
		ST50_SCHUNK_R :=	WORD#312,
		ST50_SCHUNK_R_Interface :=	WORD#313,
		ST50_SCHUNK_R_Interface_Port_1 :=	WORD#314,
		ST50_SCHUNK_R_Interface_Port_2 :=	WORD#315,
		ST50_SCHUNK_R_DEVICE_SFP :=	WORD#316,
		ST50_SCHUNK_R_IN_4_Double_Words :=	WORD#317,
		ST50_SCHUNK_R_OUT_4_Double_Words :=	WORD#318,
		ST50_TZ535_PN_Rack :=	WORD#320,
		ST50_TZ535_PN :=	WORD#321,
		ST50_TZ535_PN_Interface :=	WORD#322,
		ST50_TZ535_PN_Interface_Port_1 :=	WORD#323,
		ST50_TZ535_PN_Interface_Port_2 :=	WORD#324,
		ST50_TZ535_PN_2D_TZ535_PN_PROFINET_IO :=	WORD#325,
		ST50_TZ535_PN_In_Out_32_byte_x :=	WORD#326,
		ST50_1_DM260_WPC_Rack :=	WORD#328,
		ST50_1_DM260_WPC :=	WORD#329,
		ST50_1_DM260_WPC_Interface :=	WORD#330,
		ST50_1_DM260_WPC_Interface_Port_1 :=	WORD#331,
		ST50_1_DM260_WPC_DataMan_260 :=	WORD#332,
		ST50_1_DM260_WPC_Acquisition_Control :=	WORD#333,
		ST50_1_DM260_WPC_Acquisition_Status :=	WORD#334,
		ST50_1_DM260_WPC_Results_Control :=	WORD#335,
		ST50_1_DM260_WPC_Results_Status :=	WORD#336,
		ST50_1_DM260_WPC_Soft_Event_Control :=	WORD#337,
		ST50_1_DM260_WPC_User_Data_64_bytes :=	WORD#338,
		ST50_1_DM260_WPC_Result_Data_64_bytes :=	WORD#339,
		ST50_1_DM260_Rack :=	WORD#341,
		ST50_1_DM260 :=	WORD#342,
		ST50_1_DM260_Interface :=	WORD#343,
		ST50_1_DM260_Interface_Port_1 :=	WORD#344,
		ST50_1_DM260_DataMan_260 :=	WORD#345,
		ST50_1_DM260_Acquisition_Control :=	WORD#346,
		ST50_1_DM260_Acquisition_Status :=	WORD#347,
		ST50_1_DM260_Results_Control :=	WORD#348,
		ST50_1_DM260_Results_Status :=	WORD#349,
		ST50_1_DM260_Soft_Event_Control :=	WORD#350,
		ST50_1_DM260_User_Data_64_bytes :=	WORD#351,
		ST50_1_DM260_Result_Data_64_bytes :=	WORD#352,
		ST50_2_DM260_Rack :=	WORD#354,
		ST50_2_DM260 :=	WORD#355,
		ST50_2_DM260_Interface :=	WORD#356,
		ST50_2_DM260_Interface_Port_1 :=	WORD#357,
		ST50_2_DM260_DataMan_260 :=	WORD#358,
		ST50_2_DM260_Acquisition_Control :=	WORD#359,
		ST50_2_DM260_Acquisition_Status :=	WORD#360,
		ST50_2_DM260_Results_Control :=	WORD#361,
		ST50_2_DM260_Results_Status :=	WORD#362,
		ST50_2_DM260_Soft_Event_Control :=	WORD#363,
		ST50_2_DM260_User_Data_64_bytes :=	WORD#364,
		ST50_2_DM260_Result_Data_64_bytes :=	WORD#365,
		ST50_3_DM260_Rack :=	WORD#367,
		ST50_3_DM260 :=	WORD#368,
		ST50_3_DM260_Interface :=	WORD#369,
		ST50_3_DM260_Interface_Port_1 :=	WORD#370,
		ST50_3_DM260_DataMan_260 :=	WORD#371,
		ST50_3_DM260_Acquisition_Control :=	WORD#372,
		ST50_3_DM260_Acquisition_Status :=	WORD#373,
		ST50_3_DM260_Results_Control :=	WORD#374,
		ST50_3_DM260_Results_Status :=	WORD#375,
		ST50_3_DM260_Soft_Event_Control :=	WORD#376,
		ST50_3_DM260_User_Data_64_bytes :=	WORD#377,
		ST50_3_DM260_Result_Data_64_bytes :=	WORD#378,
		ST50_4_DM260_Rack :=	WORD#380,
		ST50_4_DM260 :=	WORD#381,
		ST50_4_DM260_Interface :=	WORD#382,
		ST50_4_DM260_Interface_Port_1 :=	WORD#383,
		ST50_4_DM260_DataMan_260 :=	WORD#384,
		ST50_4_DM260_Acquisition_Control :=	WORD#385,
		ST50_4_DM260_Acquisition_Status :=	WORD#386,
		ST50_4_DM260_Results_Control :=	WORD#387,
		ST50_4_DM260_Results_Status :=	WORD#388,
		ST50_4_DM260_Soft_Event_Control :=	WORD#389,
		ST50_4_DM260_User_Data_64_bytes :=	WORD#390,
		ST50_4_DM260_Result_Data_64_bytes :=	WORD#391,
		NONE:= WORD#0
	);
END_TYPE
