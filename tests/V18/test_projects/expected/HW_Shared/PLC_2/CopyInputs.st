FUNCTION CopyInputs
	VAR_EXTERNAL
		HwInputs : HwInputs; 
		PlcInputs : PlcInputs; 
	END_VAR
	PlcInputs.IO_device_2_DI_8x24VDC_BA_2 := HwInputs.IO_device_2_DI_8x24VDC_BA_2;
END_FUNCTION
