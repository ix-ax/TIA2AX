FUNCTION CopyInputs
	VAR_EXTERNAL
		HwInputs : HwInputs; 
		PlcInputs : PlcInputs; 
	END_VAR
	PlcInputs.IO_device_1_DI_8x24VDC_BA_1 := HwInputs.IO_device_1_DI_8x24VDC_BA_1;
END_FUNCTION
