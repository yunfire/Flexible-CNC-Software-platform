using System;
using System.Runtime.InteropServices;



		/////////////////////////////////////////////////////////////////////
		// Type Definitions
[StructLayout(LayoutKind.Sequential)]  
public struct COMMAND_INFO
{
	public int    nType; // 0: Pont to Point
	// 1: Line
	// 2: Clockwise Arc/Circle
	// 3: Counterclockwise Arc/Circle
	public int    nCommandIndex;
	public double dfFeedSpeed;

	[ MarshalAs( UnmanagedType.ByValArray, SizeConst = EpcioSeries.MCCL.MAX_AXIS_NUM )]
	public double[] dfPos;
};

[StructLayout(LayoutKind.Sequential)]  
public struct SYS_MAC_PARAM
{
	public ushort	 wPosToEncoderDir;
	public ushort	 wRPM;
	public uint	     dwPPR;
	public double    dfPitch;
	public double    dfGearRatio;
	public double    dfHighLimit;
	public double    dfLowLimit;
	public double    dfHighLimitOffset;
	public double    dfLowLimitOffset;

	public ushort    wPulseMode;
	public ushort    wPulseWidth;
	public ushort    wCommandMode;
	public ushort    wPaddle;

	public ushort    wOverTravelUpSensorMode;
	public ushort    wOverTravelDownSensorMode;
};

[StructLayout(LayoutKind.Sequential)]  
public  struct SYS_ENCODER_CONFIG
{              
	public ushort wType;
	public ushort wAInverse;
	public ushort wBInverse;
	public ushort wCInverse;
	public ushort wABSwap;
	public ushort wInputRate;
	public ushort wPaddle0;
	public ushort wPaddle1;
};

[StructLayout(LayoutKind.Sequential)]  
public struct SYS_HOME_CONFIG
{              
	public ushort	wMode;   
	public ushort	wDirection; 
	public ushort	wSensorMode;
	public ushort	wLeaveDir;
	public int	    nIndexCount;
	public int	    nPaddel1;
	public double	dfAccTime;
	public double	dfDecTime;
	public double	dfHighSpeed;
	public double	dfLowSpeed;
	public double	dfOffset;
};

[StructLayout(LayoutKind.Sequential)] 
public struct MOTION_CONFIG
{
	public char   cAccType;
	public char   cDecType;
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst = EpcioSeries.MCCL.MAX_AXIS_NUM )]
	public char[]   cPaddle;
	public double dfAccTime;//  ms
	public double dfDecTime;//  ms
	public double dfFeedSpeed;
};

[StructLayout(LayoutKind.Sequential)] 
public struct PTP_MOTION_CONFIG
{
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_AXIS_NUM )]
	public char[] cAccType;
	public char cPaddel0;
	public char cPaddel1;

	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_AXIS_NUM )]
	public char[] cDecType;
	public char cPaddel2;
	public char cPaddel3;

	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_AXIS_NUM )]
	public double[] dfAccTime;

	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_AXIS_NUM )]
	public double[] dfDecTime;
	public double dfSpeedRatio;
}

		

[StructLayout(LayoutKind.Sequential)] 
public struct SYS_COMP_PARAM
{
	public uint dwInterval;
	public ushort  wHome_No;
	public ushort  wPaddle;
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_COMP_POINT )] 
	public int[] nForwardTable;

	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_COMP_POINT )] 
	public int[] nBackwardTable;
};
		
[StructLayout(LayoutKind.Sequential)] 
public struct SYS_CARD_CONFIG
{
	public ushort wCardType;
	public ushort wCardAddress;
	public ushort wIRQ_No;
	public ushort wPaddle;
};

[StructLayout(LayoutKind.Sequential)] 
public struct SYS_GROUP_INFO_EX
{
	public int  nCardIndex;
	public int  nX;
	public int  nY;
	public int  nZ;
	public int  nU;
	public int  nV;
	public int  nW;
};

[StructLayout(LayoutKind.Sequential) ] 
public class SYS_GROUP_CONFIG_EX
{
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_GROUP_NUM )]
	public int[] nGroupUsed;
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_GROUP_NUM )]
	public SYS_GROUP_INFO_EX[] stGroupInfo;
	public SYS_GROUP_CONFIG_EX()
	{
		nGroupUsed = new int[EpcioSeries.MCCL.MAX_GROUP_NUM];
		stGroupInfo = new SYS_GROUP_INFO_EX[EpcioSeries.MCCL.MAX_GROUP_NUM];
	}
};
		

		/////////////////////////////////////////////////////////////////////
		// Old Definitions in MCCL V.4.5
[StructLayout(LayoutKind.Sequential)] 
public struct HOME_CONFIG
{              
	public ushort   wType;  
	public ushort   wPhase0Dir; 
	public ushort   wPhase1Dir; 
	public ushort   wSensorMode;
	public double   dfOffset;
};
	
[StructLayout(LayoutKind.Sequential)]  
public  struct ENCODER_CONFIG
{              
	public ushort wType;
	public ushort wAInverse;
	public ushort wBInverse;
	public ushort wCInverse;
	public ushort wABSwap;
	public ushort wInputRate;
	public ushort wPaddle0;
	public ushort wPaddle1;
};

[StructLayout(LayoutKind.Sequential)] 
public struct SYS_MACH_PARAM
{
	public ushort		   wPosToEncoderDir;
	public ushort		   wRPM;
	public uint			   dwPPR;
	public double		   dfPitch;
	public double		   dfGearRatio;
	public double		   dfHighLimit;
	public double		   dfLowLimit;
	public double		   dfHighLimitOffset;
	public double		   dfLowLimitOffset;

	public ushort		   wPulseMode;
	public ushort          wPulseWidth;
	public ushort          wCommandMode;
	public ushort          wPaddle;

	public HOME_CONFIG     stHome; 
	public ENCODER_CONFIG  stEncoder;

	public ushort          wOverTravelUpSensorMode;
	public ushort          wOverTravelDownSensorMode;
};
	
[StructLayout(LayoutKind.Sequential)] 
public struct SYS_GROUP_INFO
{
	public int  nCardIndex;
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_AXIS_NUM )] 
	public int[]  nChannel;
};
	
[StructLayout(LayoutKind.Sequential)] 
public struct SYS_GROUP_CONFIG
{
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_GROUP_NUM )]
	public int[] nGroupUsed;
	[ MarshalAs( UnmanagedType.ByValArray, SizeConst=EpcioSeries.MCCL.MAX_GROUP_NUM )]
	public SYS_GROUP_INFO[] stGroupInfo;
};


		//#if !defined(_EPCIO_DEV_H_) && !defined(_ACTADRV_H_)
[StructLayout(LayoutKind.Sequential)] 
public struct ENCINT
{
	public byte COMP0;
	public byte COMP1;
	public byte COMP2;
	public byte INDEX0;
	public byte INDEX1;
	public byte INDEX2;
};

[StructLayout(LayoutKind.Sequential)] 
public struct PCLINT
{
	public byte OV0;
	public byte OV1;
	public byte OV2;
	public byte OV3;
	public byte OV4;
	public byte OV5;
};
		
[StructLayout(LayoutKind.Sequential)]  
public struct ADCINT
{
	public byte COMP0;
	public byte COMP1;
	public byte COMP2;
	public byte COMP3;
	public byte COMP4;
	public byte COMP5;
	public byte COMP6;
	public byte COMP7;
	public byte CONV;
	public byte TAG;
};

[StructLayout(LayoutKind.Sequential)] 
public struct LIOINT
{
	public byte LDI0;
	public byte LDI1;
	public byte LDI2;
	public byte LDI3;
	public byte LDI4;
	public byte LDI5;
	public byte LDI6;
	public byte LDI7;
	public byte DFI0;
	public byte DFI1;
	public byte DFI2;
	public byte DFI3;
	public byte DFI4;
	public byte DFI5;
	public byte DFI6;
	public byte TIMER;
};

[StructLayout(LayoutKind.Sequential)] 
public struct RIOINT
{
	public byte S0DI0;
	public byte S0DI1;
	public byte S0DI2;
	public byte S0DI3;
	public byte S1DI0;
	public byte S1DI1;
	public byte S1DI2;
	public byte S1DI3;
	public byte S2DI0;
	public byte S2DI1;
	public byte S2DI2;
	public byte S2DI3;
	public byte FAIL;
};

[StructLayout(LayoutKind.Sequential)] 
public struct ENCINT_EX
{
	public byte COMP0;
	public byte COMP1;
	public byte COMP2;
	public byte COMP3;
	public byte COMP4;
	public byte COMP5;
	public byte INDEX0;
	public byte INDEX1;
	public byte INDEX2;
	public byte INDEX3;
	public byte INDEX4;
	public byte INDEX5;
};

[StructLayout(LayoutKind.Sequential)] 
public struct LIOINT_EX
{
	public byte LDI0;
	public byte LDI1;
	public byte LDI2;
	public byte LDI3;
	public byte LDI4;
	public byte LDI5;
	public byte LDI6;
	public byte TIMER;
};

[StructLayout(LayoutKind.Sequential)] 
public struct RIOINT_EX
{
	public byte SET0_DI0;
	public byte SET0_DI1;
	public byte SET0_DI2;
	public byte SET0_DI3;
	public byte SET0_FAIL;
	public byte SET1_DI0;
	public byte SET1_DI1;
	public byte SET1_DI2;
	public byte SET1_DI3;
	public byte SET1_FAIL;
} ;
	
	

namespace EpcioSeries
{
	/// <summary>
	/// Summary description for MCCL.
	/// </summary>
	public class MCCL
	{
		public MCCL()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	

		/////////////////////////////////////////////////////////////////////
		// Variable definitions
		public const string LibNameVersion = "MCCLPCI_50.DLL";

		public const int CARDTYPE0 = 0;
		public const int CARDTYPE1 = 1;
		public const int CARDTYPE2 = 2;
		public const int CARDTYPE3 = 3;

		public const int GROUPINDEX0 = 0;
		public const int GROUPINDEX1 = 1;
		public const int GROUPINDEX2 = 2;
		public const int GROUPINDEX3 = 3;
		public const int GROUPINDEX4 = 4;
		public const int GROUPINDEX5 = 5;

		public const int CARDINDEX0 = 0;
		public const int CARDINDEX1 = 1;

		public const int COMMAND_QUEUE_SIZE = 10000;
		
		public const int INTERPOLATION_TIME = 5;

		public const int MAX_CARD_NUM = 12;
		public const int MAX_AXIS_NUM		=			6;
		public const int MAX_GROUP_NUM		=			72;

		public const int _YES_			=			1;
		public const int _NO_			=			0;

		public const int GROUP_VALID		=			0;
		public const int GROUP_INVALID		=			-1;
		public const int AXIS_INVALID		=			-1;

		public const int INVERSE_YES        =            1;
		public const int INVERSE_NO         =            0;		

		/////////////////////////////////////////////////////////////////////
		// Range Definitions of Interpolation Period (ms)
                 
		public const int IPO_PERIOD_MIN		=			1;
		public const int IPO_PERIOD_MAX		=			50;
                
                
		/////////////////////////////////////////////////////////////////////
		// Definitions of Output Command Modes
                
		public const int OCM_PULSE		=			0;
		public const int OCM_VOLTAGE		=			1;
                
                
		/////////////////////////////////////////////////////////////////////
		// Unit Definitions
                
		public const int UNIT_MM		=			1;
		public const int UNIT_INCH		=			2;
                
                
		/////////////////////////////////////////////////////////////////////
		// Home Mode Definitions (obsolete, just for compatibility)
                
		public const int HM_NORMAL			=			0;
		public const int HM_SENSOR_ONLY		=			1;
		public const int HM_INDEX_ONLY		=			2;
                
		/////////////////////////////////////////////////////////////////////
		// Definitions of Sensor Logic

		public const int SL_NORMAL_OPEN		=			0;
		public const int SL_NORMAL_CLOSE	=			1;
		public const int SL_UNUSED			=			2;

              
		/////////////////////////////////////////////////////////////////////
		// Definitions of In-Position Modes
                
		public const int IPM_ONETIME_BLOCK	=		0;
		public const int IPM_ONETIME_UNBLOCK	=		1;
		public const int IPM_SETTLE_BLOCK	=		2;
		public const int IPM_SETTLE_UNBLOCK	=		3;
                
                
		/////////////////////////////////////////////////////////////////////
		// Definitions of Group Motion Status
                
		public const int GMS_RUNNING		=		0;
		public const int GMS_STOP			=		1;
		public const int GMS_HOLD			=		2;
		public const int GMS_DELAYING		=		3;
                
                
		/////////////////////////////////////////////////////////////////////
		// Definitions of MCCL Axis Flag
                
		public const uint EPCIO_AXIS_X		=		0x0001;
		public const uint EPCIO_AXIS_Y		=		0x0002;
		public const uint EPCIO_AXIS_Z		=		0x0004;
		public const uint EPCIO_AXIS_U		=		0x0008;
		public const uint EPCIO_AXIS_V		=		0x0010;
		public const uint EPCIO_AXIS_W		=		0x0020;
		public const uint EPCIO_AXIS_ALL	=		0x003f;
                
                
		/////////////////////////////////////////////////////////////////////
		// MCCL Error Codes Definitions
                
		public const int NO_ERR					=	  0;
		public const int INITIAL_MOTION_ERR			=	 -1;
		public const int COMMAND_BUFFER_FULL_ERR		=	 -2;
		public const int COMMAND_NOTACCEPTED_ERR		=	 -3; 
		public const int COMMAND_NOTFINISHED_ERR		=	 -4;
		public const int PARAMETER_ERR				=	 -5;
		public const int GROUP_PARAMETER_ERR			=	 -6;
		public const int FEED_RATE_ERR				=	 -7;
		public const int BLEND_COMMAND_NOTCALLED_ERR		=	 -8;
		public const int VOLTAGE_COMMAND_CHANNEL_ERR		=	 -9;
		public const int HOME_COMMAND_NOTCALLED_ERR		=	-10;
		public const int HOLD_ILLEGAL_ERR			=	-11; 
		public const int CONTI_ILLEGAL_ERR			=	-12; 
		public const int ABORT_ILLEGAL_ERR			=	-13;
		public const int RUN_TIME_ERR				=	-14;
                
                
		/////////////////////////////////////////////////////////////////////
		// Compensation-related Definitions
                
		public const int MAX_COMP_POINT				=	256;
            
		//#ifndef _EPCIO_INI_H_
		/////////////////////////////////////////////////////////////////////
		// Output Pulse Format Definitions
                
		public const int DDA_FMT_PD				=	0x0; // Pulse/Dir
		public const int DDA_FMT_CW				=	0x1; // CW/CCW
		public const int DDA_FMT_AB				=	0x2; // A/B Phase
		public const int DDA_FMT_NO				=	0x3; // No pulse output
                
                
		/////////////////////////////////////////////////////////////////////
		// Encoder Type Definitions
                
		public const int ENC_TYPE_AB				=	0x0; // A/B Phase
		public const int ENC_TYPE_CW				=	0x1; // CW/CCW
		public const int ENC_TYPE_PD				=	0x2; // Pulse/Dir
		public const int ENC_TYPE_NO				=	0x3; // No pulse input
                
                
		/////////////////////////////////////////////////////////////////////
		// Encoder Latch Trigger Mode Definitions
                
		public const int ENC_TRIG_FIRST				=	0x0;
		public const int ENC_TRIG_LAST				=	0x1;
                
                
		/////////////////////////////////////////////////////////////////////
		// Encoder Trigger Source Definitions
       
		public const int ENC_TRIG_NO	        = 	0x0000;
		public const int ENC_TRIG_INDEX0		=   0x0001;
		public const int ENC_TRIG_INDEX1		=	0x0002;
		public const int ENC_TRIG_INDEX2		=	0x0004;
		public const int ENC_TRIG_INDEX3		=	0x0008;
		public const int ENC_TRIG_INDEX4		=	0x0010;
		public const int ENC_TRIG_INDEX5		=	0x0020;
		public const int ENC_TRIG_INDEX6		=	0x0040;
		public const int ENC_TRIG_INDEX7		=	0x0080;
		public const int ENC_TRIG_INDEX8		=	0x0100;
		public const int ENC_TRIG_LDI0			=	0x0200;
		public const int ENC_TRIG_LDI1			=	0x0400;
		public const int ENC_TRIG_RDI0			=	0x0800;
		public const int ENC_TRIG_RDI1			=	0x1000;
		public const int ENC_TRIG_ADC0			=	0x2000;
		public const int ENC_TRIG_ADC1			=	0x4000;
                
                
		/////////////////////////////////////////////////////////////////////
		// Local I/O Interrupt Trigger Type Definitions
                
		public const int LIO_INT_RISE			=	   0x0;
		public const int LIO_INT_FALL			=	   0x1;
		public const int LIO_INT_LEVEL			=	   0x2;
                
                
		/////////////////////////////////////////////////////////////////////
		// Local I/O Interrupt Trigger Source Definitions
                
		public const int LIO_LDI0			=	   0x0;
		public const int LIO_LDI1			=	   0x1;
		public const int LIO_LDI2			=	   0x2;
		public const int LIO_LDI3			=	   0x3;
		public const int LIO_LDI4			=	   0x4;
		public const int LIO_LDI5			=	   0x5;
		public const int LIO_LDI6			=	   0x6;
                
                
		/////////////////////////////////////////////////////////////////////
		// DAC Interrupt Trigger Source Definitions
                
		public const ulong DAC_TRIG_ENC0	         =   0x00000001;
		public const ulong DAC_TRIG_ENC1	         =   0x00000002;
		public const ulong DAC_TRIG_ENC2	         =   0x00000004;
		public const ulong DAC_TRIG_ENC3	         =   0x00000008;
		public const ulong DAC_TRIG_ENC4	         =   0x00000010;
		public const ulong DAC_TRIG_ENC5	         =   0x00000020;
		public const ulong DAC_TRIG_ENC6	         =   0x00000040;
		public const ulong DAC_TRIG_ENC7	         =   0x00000080;
		public const ulong DAC_TRIG_ADC0	         =   0x00000100;
		public const ulong DAC_TRIG_ADC1	         =   0x00000200;
		public const ulong DAC_TRIG_ADC2	         =   0x00000400;
		public const ulong DAC_TRIG_ADC3	         =   0x00000800;
		public const ulong DAC_TRIG_ADC4	         =   0x00001000;
		public const ulong DAC_TRIG_ADC5	         =   0x00002000;
		public const ulong DAC_TRIG_ADC6	         =   0x00004000;
		public const ulong DAC_TRIG_ADC7	         =   0x00008000;
		public const ulong DAC_TRIG_LDI0	         =   0x00010000;
		public const ulong DAC_TRIG_LDI1	         =   0x00020000;
		public const ulong DAC_TRIG_LDI2	         =   0x00040000;
		public const ulong DAC_TRIG_LDI3	         =   0x00080000;
		public const ulong DAC_TRIG_DFI0	         =   0x00100000;
		public const ulong DAC_TRIG_DFI1	         =   0x00200000;
		public const ulong DAC_TRIG_DFI2	         =   0x00400000;
		public const ulong DAC_TRIG_DFI3	         =   0x00800000;
		public const ulong DAC_TRIG_R0DI0	         =   0x01000000;
		public const ulong DAC_TRIG_R0DI1	         =   0x02000000;
		public const ulong DAC_TRIG_R0DI2	         =   0x04000000;
		public const ulong DAC_TRIG_R0DI3	         =   0x08000000;
		public const ulong DAC_TRIG_R1DI0	         =   0x10000000;
		public const ulong DAC_TRIG_R1DI1	         =   0x20000000;
		public const ulong DAC_TRIG_R1DI2	         =   0x40000000;
		public const ulong DAC_TRIG_R1DI3	         =   0x80000000;
                
                
		/////////////////////////////////////////////////////////////////////
		// ADC Compare Type Definitions
                
		public const int ADC_COMP_RISE			=       	0x0;
		public const int ADC_COMP_FALL	                = 		0x1;
		public const int ADC_COMP_LEVEL	                = 		0x2;
                
                
		/////////////////////////////////////////////////////////////////////
		// ADC Compare Mask Definitions
                
		public const int ADC_MASK_NO	                 =  		0x0;
		public const int ADC_MASK_BIT1	                 =  		0x1;
		public const int ADC_MASK_BIT2	                 =  		0x2;
		public const int ADC_MASK_BIT3	                 =  		0x3;
                
		/////////////////////////////////////////////////////////////////////
		// ADC Converting Type Definitions
                
		public const int ADC_TYPE_BIP	                  = 		0x0;
		public const int ADC_TYPE_UNI	                  = 		0x1;
                
                
		/////////////////////////////////////////////////////////////////////
		// ADC Converting Mode Definitions
                
		public const int ADC_MODE_SINGLE                   = 		0x0;
		public const int ADC_MODE_FREE	                   = 		0x1;
                
                
		/////////////////////////////////////////////////////////////////////
		// Remote I/O Set Definitions
                
		public const int RIO_SET0				=	   0x0;
		public const int RIO_SET1				=	   0x1;
                
                
		/////////////////////////////////////////////////////////////////////
		// Remote I/O Port Definitions
                
		public const int RIO_PORT0				=	   0x0;
		public const int RIO_PORT1				=	   0x1;
		public const int RIO_PORT2				=	   0x2;
		public const int RIO_PORT3				=	   0x3;
                
                
		/////////////////////////////////////////////////////////////////////
		// Remote I/O Interrupt Trigger Source Definitions
                
		public const int RIO_DI0				=	  0x0;
		public const int RIO_DI1				=	  0x1;
		public const int RIO_DI2				=	  0x2;
		public const int RIO_DI3				=	  0x3;
                
                
		/////////////////////////////////////////////////////////////////////
		// Remote I/O Interrupt Trigger Type Definitions
                
		public const int RIO_INT_RISE				=	   0x0;
		public const int RIO_INT_FALL				=	   0x1;
		public const int RIO_INT_LEVEL				=	   0x2;

		//#endif // _EPCIO_INI_H_

		public delegate void LIOISR_EX( ref LIOINT_EX value);
		public delegate void ENCISR_EX( ref ENCINT_EX value);
		public delegate void RIOISR_EX( ref RIOINT_EX value);
		public delegate void PCLISR( ref PCLINT value);
		public delegate void ADCISR( ref ADCINT value);
		public delegate void LIOISR( ref LIOINT value);
		public delegate void ENCISR( ref ENCINT value);
		public delegate void RIOISR( ref RIOINT value);

	
		// Get Library Version
		[ DllImport( LibNameVersion )]
		public static extern void   MCC_GetVersion(ref char strVersion);

		// Set Configure Parameters
		[ DllImport( LibNameVersion )]
		//public static extern int     MCC_CreateGroup(int xMapToCh, int yMapToCh, int zMapToCh, int uMapToCh, int vMapToCh, int wMapToCh, int nCardIndex);
		public static extern int     MCC_CreateGroup(int xMapToCh, int yMapToCh, int zMapToCh, int uMapToCh, int vMapToCh, int wMapToCh, int nCardIndex, int nMotionQueueSize);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CloseGroup(int nGroupIndex);
		
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CloseAllGroups();

		// Set/Get Mechanism Parameters
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetMacParam(ref SYS_MAC_PARAM pstMacParam, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetMacParam(ref SYS_MAC_PARAM pstMacParam, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_UpdateParam();
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetEncoderConfig(ref SYS_ENCODER_CONFIG pstEncoderConfig, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetEncoderConfig(ref SYS_ENCODER_CONFIG pstEncoderConfig, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetHomeConfig(ref SYS_HOME_CONFIG pstHomeConfig, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetHomeConfig(ref SYS_HOME_CONFIG pstHomeConfig, ushort wChannel, ushort wCardIndex);

		// Set/Get Max. Feed Speed
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetSysMaxSpeed(double dfMaxSpeed);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetSysMaxSpeed();

		// Set/Get size of motion command queue
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetCmdQueueSize(int nSize, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCmdQueueSize(ushort wGroupIndex);

		// Initialize/Close System
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_InitSystem(int nInterpolateTime, ref SYS_CARD_CONFIG psCardConfig, ushort wCardNo);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_InitSimulation(int nInterpolateTime, ref SYS_CARD_CONFIG pstCardConfig, ushort wCardNo);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CloseSystem();

		// Reset MCCL
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ResetMotion();

		// Enable/Disable Dry Run
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableDryRun();
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableDryRun();
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CheckDryRun();


		//////////////////////////////////////////////////////////////////////////////
		// Local I/O Control

		// Servo On/Off
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetServoOn(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetServoOff(ushort wChannel, ushort wCardIndex);

		// Enable/Disable Position Ready
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnablePosReady(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisablePosReady(ushort wCardIndex);

		// Get Emergency Stop Status
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetEmgcStopStatus(ref ushort pwStatus, ushort wCardIndex);

		// Input Signal Trigger
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetLIORoutineEx(LIOISR_EX pfnLIORoutine, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetLIOTriggerType(ushort wTriggerType, ushort wPoint, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableLIOTrigger(ushort wPoint, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableLIOTrigger(ushort wPoint, ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Coordinate Management

		// Set/Get Coordinate Unit
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetUnit(int nUnitMode, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetUnit(ushort wGroupIndex);

		// Set/Get Coordinate Type
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetAbsolute(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetIncrease(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCoordType(ushort wGroupIndex);

		// Get Current Position & Pulse Position
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCurRefPos(ref double pdfX, ref double pdfY, ref double pdfZ, ref double pdfU, ref double pdfV, ref double pdfW, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCurPos(ref double pdfX, ref double pdfY, ref double pdfZ, ref double pdfU, ref double pdfV, ref double pdfW, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPulsePos(ref long plX, ref long plY, ref long plZ, ref long plU, ref long plV, ref long plW, ushort wGroupIndex);

		// Coordinate Management
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DefineOrigin(ushort wAxis, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DefinePosHere(ushort wGroupIndex, uint dwAxisMask);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DefinePos(double dfCart, ushort wAxis, ushort wGroupIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Software Over Travel Check & Hardware Limit Switch Check

		// Enable/Disable Hardware Limit Switch Check
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableLimitSwitchCheck(int nMode);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableLimitSwitchCheck();

		// Enable/Disable Software Over Travel Check
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetOverTravelCheck(int nOTCheck0, int nOTCheck1, int nOTCheck2, int nOTCheck3, int nOTCheck4, int nOTCheck5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetOverTravelCheck(ref int pnOTCheck0, ref int pnOTCheck1, ref int pnOTCheck2, ref int pnOTCheck3, ref int pnOTCheck4, ref int pnOTCheck5, ushort wGroupIndex);

		// Get Limit Switch Sensor Signal
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetLimitSwitchStatus(ref ushort pwStatus, ushort wUpDown, ushort wChannel, ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// General Motions(Line, Arc, Circle, Helical Motions)

		// Set/Get Accleration & Deceleration Types
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetAccType(char cAccType, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetAccType(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDecType(char cDecType, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetDecType(ushort wGroupIndex);		
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetAccDecMode(char cAccDecMode, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetAccDecMode(ushort wGroupIndex);

		// Set/Get Accleration & Deceleration Times(Steps)
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetAccTime(double dfAccTime, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetAccTime(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDecTime(double dfDecTime, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetDecTime(ushort wGroupIndex);

		// Set/Get Feed Speed
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_SetFeedSpeed(double dfFeedSpeed, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetFeedSpeed(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetCurFeedSpeed(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetSpeed(ref double pdfVel0, ref double pdfVel1, ref double pdfVel2, ref double pdfVel3, ref double pdfVel4, ref double pdfVel5, ushort wGroupIndex);

		// Line Motion
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_Line(double dfX0, double dfX1, double dfX2, double dfX3, double dfX4, double dfX5, ushort wGroupIndex, uint dwAxisMask);

		// Arc Motion
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcXYZ(double dfRX0, double dfRX1, double dfRX2, double dfX0, double dfX1, double dfX2, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcXY(double dfRX0, double dfRX1, double dfX0, double dfX1, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcYZ(double dfRX1, double dfRX2, double dfX1, double dfX2, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcZX(double dfRX2, double dfRX0, double dfX2, double dfX0, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcXYZUVW(double dfRX0, double dfRX1, double dfRX2, double dfX0, double dfX1, double dfX2, double dfX3, double dfX4, double dfX5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcXYUVW(double dfRX0, double dfRX1, double dfX0, double dfX1, double dfX3, double dfX4, double dfX5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcYZUVW(double dfRX1, double dfRX2, double dfX1, double dfX2, double dfX3, double dfX4, double dfX5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcZXUVW(double dfRX2, double dfRX0, double dfX2, double dfX0, double dfX3, double dfX4, double dfX5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcThetaXY(double dfX0, double dfX1, double dfTheta, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcThetaYZ(double dfX1, double dfX2, double dfTheta, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcThetaZX(double dfX2, double dfX0, double dfTheta, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcThetaXYUVW(double dfX0, double dfX1, double dfU, double dfV, double dfW, double dfTheta, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcThetaYZUVW(double dfX1, double dfX2, double dfU, double dfV, double dfW, double dfTheta, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ArcThetaZXUVW(double dfX2, double dfX0, double dfU, double dfV, double dfW, double dfTheta, ushort wGroupIndex);

		// Circle Motion
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CircleXY(double dfCX0, double dfCX1, byte byCirDir, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CircleYZ(double dfCX1, double dfCX2, byte byCirDir, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CircleZX(double dfCX2, double dfCX0, byte byCirDir, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CircleXYUVW(double dfCX0, double dfCX1, double dfU, double dfV, double dfW, byte byCirDir, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CircleYZUVW(double dfCX1, double dfCX2, double dfU, double dfV, double dfW, byte byCirDir, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CircleZXUVW(double dfCX2, double dfCX0, double dfU, double dfV, double dfW, byte byCirDir, ushort wGroupIndex);

		// Helica Motion
		[ DllImport( LibNameVersion )]
		//public static extern int     MCC_HelicaXY_Z(double dfCX, double dfCY, double dfTurns, double dfPitch, byte byCirDir, ushort wGroupIndex);
		public static extern int     MCC_HelicalXY_Z(double dfCX, double dfCY, double dfPitch, double dfAngle, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		//public static extern int     MCC_HelicaYZ_X(double dfCY, double dfCZ, double dfTurns, double dfPitch, byte byCirDir, ushort wGroupIndex);
		public static extern int     MCC_HelicalYZ_X(double dfCY, double dfCZ, double dfPitch, double dfAngle, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		//public static extern int     MCC_HelicaZX_Y(double dfCZ, double dfCX, double dfTurns, double dfPitch, byte byCirDir, ushort wGroupIndex);
		public static extern int     MCC_HelicalZX_Y(double dfCZ, double dfCX, double dfPitch, double dfAngle, ushort wGroupIndex);

		//////////////////////////////////////////////////////////////////////////////
		// Point to Point Motion

		// Set/Get Accleration & Deceleration Types
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPtPAccType(char cAccType0, char cAccType1, char cAccType2, char cAccType3, char cAccType4, char cAccType5,  ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPtPAccType(ref char pcAccType0, ref char pcAccType1, ref char pcAccType2, ref char pcAccType3, ref char pcAccType4, ref char pcAccType5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPtPDecType(char cDecType0, char cDecType1, char cDecType2, char cDecType3, char cDecType4, char cDecType5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPtPDecType(ref char pcDecType0, ref char pcDecType1, ref char pcDecType2, ref char pcDecType3, ref char pcDecType4, ref char pcDecType5, ushort wGroupIndex);

		// Set/Get Accleration & Deceleration Times(Steps)
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPtPAccTime(double dfAccTime0, double dfAccTime1, double dfAccTime2, double dfAccTime3, double dfAccTime4, double dfAccTime5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPtPAccTime(ref double pdfAccTime0, ref double pdfAccTime1, ref double pdfAccTime2, ref double pdfAccTime3, ref double pdfAccTime4, ref double pdfAccTime5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPtPDecTime(double dfDecTime0, double dfDecTime1, double dfDecTime2, double dfDecTime3, double dfDecTime4, double dfDecTime5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPtPDecTime(ref double pdfDecTime0, ref double pdfDecTime1, ref double pdfDecTime2, ref double pdfDecTime3, ref double pdfDecTime4, ref double pdfDecTime5, ushort wGroupIndex);

		// Set/Get Speed Ratio
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_SetPtPSpeed(double dfRatio, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetPtPSpeed(ushort wGroupIndex);

		// Point to Point Motion
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtP(double dfX0, double dfX1, double dfX2, double dfX3, double dfX4, double dfX5, ushort wGroupIndex, uint dwAxisMask);

		//////////////////////////////////////////////////////////////////////////////
		// JOG Motion

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_JogPulse(int nPulse, char cAxis, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_JogSpace(double dfOffset, double dfRatio, char cAxis, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_JogConti(int nDir, double dfRatio, char cAxis, ushort wGroupIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Motion Status

		// Get Current Motion Status
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetMotionStatus(ushort wGroupIndex);

		// Get Current Executing Motion Command
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCurCommand(ref COMMAND_INFO pstCurCommand, ushort wGroupIndex);

		// Get Motion Command Stock Count
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCommandCount(ref int pnCmdCount, ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ResetCommandIndex(ushort wGroupIndex);

		// Set/Get maximum number of the hardware pulse stock
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetMaxPulseStockNum(int nMaxStockNum);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetMaxPulseStockNum();

		// Get hardware pulse stock count
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetCurPulseStockCount(ref ushort pwStockCount, ushort wChannel, ushort wCardIndex);

		// Get/Clear Error Code
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetErrorCode(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ClearError(ushort wGroupIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Go Home

		// Operations 
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_Home(int nXOrder, int nYOrder, int nZOrder, int nUOrder, int nVOrder, int nWOrder, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetGoHomeStatus();
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_AbortGoHome();

		// Get Home Sensor Signal
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetHomeSensorStatus(ref ushort pwStatus, ushort wChannel, ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Position Control

		// Set/Get Pulse Speed & Accleration
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetMaxPulseSpeed(int nPulse0, int nPulse1, int nPulse2, int nPulse3, int nPulse4, int nPulse5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetMaxPulseSpeed(ref int pnSpeed0, ref int pnSpeed1, ref int pnSpeed2, ref int pnSpeed3, ref int pnSpeed4, ref int pnSpeed5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetMaxPulseAcc(int nPulseAcc0, int nPulseAcc1, int nPulseAcc2, int nPulseAcc3, int nPulseAcc4, int nPulseAcc5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetMaxPulseAcc(ref int pnPulseAcc0, ref int pnPulseAcc1, ref int pnPulseAcc2, ref int pnPulseAcc3, ref int pnPulseAcc4, ref int pnPulseAcc5, ushort wCardIndex);

		// Set Compensation Table
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetCompParam(ref SYS_COMP_PARAM pstCompParam, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_UpdateCompParam();

		// Set/Get P Gain for Position Control Loop
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPGain(ushort wGain0, ushort wGain1, ushort wGain2, ushort wGain3, ushort wGain4, ushort wGain5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPGain(ref ushort pwGain0, ref ushort pwGain1, ref ushort pwGain2, ref ushort pwGain3, ref ushort pwGain4, ref ushort pwGain5, ushort wCardIndex);

		// In Postion Operations
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInPosMode(ushort wMode, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInPosMaxCheckTime(ushort wMaxCheckTime, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInPosSettleTime(ushort wSettleTime, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableInPos(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableInPos(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInPosToleranceEx(double dfTolerance0, double dfTolerance1, double dfTolerance2, double dfTolerance3, double dfTolerance4, double dfTolerance5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetInPosToleranceEx(ref double pdfTolerance0, ref double pdfTolerance1, ref double pdfTolerance2, ref double pdfTolerance3, ref double pdfTolerance4, ref double pdfTolerance5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetInPosStatus(ref byte pbyInPos0, ref byte pbyInPos1, ref byte pbyInPos2, ref byte pbyInPos3, ref byte pbyInPos4, ref byte pbyInPos5, ushort wGroupIndex);

		// Tracking Error Detection
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableTrackError( ushort wGroupIndex, uint dwAxisMask);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableTrackError(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetTrackErrorLimit(double   dfLimit, char cAxis, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetTrackErrorLimit(ref double pdfLimit, char cAxis, ushort wGroupIndex);

		// Link PCL Interrupt Service Function

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPCLRoutine(PCLISR pfnPCLRoutine, ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Advanced Trajectory Planning

		// Hold/Continue/Abort Motion
		[ DllImport( LibNameVersion )]
		//public static extern int     MCC_HoldMotion(ushort wGroupIndex);
		public static extern int     MCC_HoldMotion(ushort wGroupIndex, bool bAfterCmd);        
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ContiMotion(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_AbortMotionEx(double dfDecTime, ushort wGroupIndex);

		// Enable/Disable Motion Blending
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableBlend(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableBlend(ushort wGroupIndex); 
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CheckBlend(ushort wGroupIndex);

		// Set Delay Time
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DelayMotion(uint dwTime, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern void    MCC_TimeDelay(uint dwTime);

		// Set/Get Over-Speed Ratio for General Motions
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_OverrideSpeed(double dfRate, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetOverrideRate(ushort wGroupIndex);

		// Set/Get Over-Speed Ratio for Point to Point Motion
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_OverridePtPSpeed(double dfRate, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetPtPOverrideRate(ushort wGroupIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Encoder Control

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetENCRoutineEx(ENCISR_EX pfnEncoderRoutine, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetENCFilterClock(ushort wDivider, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetENCInputRate(ushort wInputRate, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_ClearENCCounter(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetENCValue(ref int plValue, ushort wChannel, ushort wCardIndex);

		[ DllImport( LibNameVersion )]
		public static extern int	    MCC_SetENCLatchType(ushort wType, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int	    MCC_SetENCLatchSource(ushort wSource, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int	    MCC_GetENCLatchValue(ref int plLatchValue, ushort wChannel, ushort wCardIndex);

		[ DllImport( LibNameVersion )]
		public static extern int	    MCC_EnableENCIndexTrigger(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int	    MCC_DisableENCIndexTrigger(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int	    MCC_GetENCIndexStatus(ref ushort pwStatus, ushort wChannel, ushort wCardIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetENCCompValue(int lValue, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableENCCompTrigger(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableENCCompTrigger(ushort wChannel, ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// Timer & Watch Dog Control

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetTimer(uint dwValue, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableTimer(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableTimer(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableTimerTrigger(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableTimerTrigger(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetWatchDogTimer(ushort wValue, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetWatchDogResetPeriod(uint dwValue, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableWatchDogTimer(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableWatchDogTimer(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_RefreshWatchDogTimer(ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// D/A Converter Control

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDACUpdateRate(double dfUpdateRate, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDACOutput(float fVoltage, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDACTriggerOutput(float fVoltage, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDACTriggerSource(uint dwSource, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableDACTriggerMode(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableDACTriggerMode(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_StartDACConv(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_StopDACConv(ushort wCardIndex);


		//////////////////////////////////////////////////////////////////////////////
		// A/D Converter Control

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCRoutine(ADCISR pfnADCRoutine, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCUpdateRate(double dfUpdateRate, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCConvType(ushort wConvType, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetADCConvType(ref ushort pwConvType, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCConvMode(ushort wConvMode, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetADCInput(ref float pfInput, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCSingleChannel(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetADCWorkStatus(ref ushort pwSTatus, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableADCConvTrigger(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableADCConvTrigger(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCTagChannel(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableADCTagTrigger(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableADCTagTrigger(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCCompMask(ushort wMask, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCCompType(ushort wCompType, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCCompValue(float fValue, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetADCCompValue(ref float pfValue, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableADCCompTrigger(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableADCCompTrigger(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableADCConvChannel(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableADCConvChannel(ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_StartADCConv(ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_StopADCConv(ushort wCardIndex);

 
		//////////////////////////////////////////////////////////////////////////////
		// Remote Input/Output Control

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIORoutineEx(RIOISR_EX pfnRIORoutine, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIOUpdateRate(double dfUpdateRate, ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableRIOSetControl(ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableRIOSetControl(ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableRIOSlaveControl(ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableRIOSlaveControl(ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetRIOTransStatus(ref ushort pwStatus, ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetRIOMasterStatus(ref ushort pwStatus, ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetRIOSlaveStatus(ref ushort pwStatus, ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetRIOInputValue(ref ushort pwValue, ushort wSet, ushort wPort, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIOOutputValue(ushort wValue, ushort wSet, ushort wPort, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnquRIOOutputValue(ushort wValue,ushort wMask, ushort wSet, ushort wPort, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIOTransError(ushort wTime, ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIOTriggerType(ushort wType, ushort wSet, ushort wDigitalInput, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableRIOInputTrigger(ushort wSet, ushort wDigitalInput, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableRIOInputTrigger(ushort wSet, ushort wDigitalInput, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_EnableRIOTransTrigger(ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_DisableRIOTransTrigger(ushort wSet, ushort wCardIndex);
        

		//////////////////////////////////////////////////////////////////////////////
		// Obsolete functions in earlier MCCL version (just for compatibility)

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetGroupConfig(IntPtr pstConfig);

//		[ DllImport( LibNameVersion )]
//		public static extern int     MCC_SetGroupConfig(ref SYS_GROUP_CONFIG pstConfig);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetMachParam(ref SYS_MACH_PARAM pstMachParam, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetMachParam(ref SYS_MACH_PARAM pstMachParam, ushort wChannel, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_UpdateMachParam();

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInterpolateTime(double dfTime);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetInterpolateTime();

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineX(double dfX, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineY(double dfY, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineZ(double dfZ, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineU(double dfU, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineV(double dfV, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineW(double dfW, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_LineUVW(double dfU, double dfV, double dfW, ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtPX(double dfX, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtPY(double dfY, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtPZ(double dfZ, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtPU(double dfU, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtPV(double dfV, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_PtPW(double dfW, ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetLIORoutine(LIOISR pfnLIORoutine, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetENCRoutine(ENCISR pfnEncoderRoutine, ushort wMode, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIORoutine(RIOISR pfnRIORoutine, ushort wSet, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDACClockDivider(ushort wDivider, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetADCClockDivider(ushort wDivider, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetRIOClockDivider(ushort wDivider, ushort wSet, ushort wCardIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetAccStep(int nStep, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetAccStep(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetDecStep(int nStep, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetDecStep(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPtPAccStep(int nStep0, int nStep1, int nStep2, int nStep3, int nStep4, int nStep5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPtPAccStep(ref int pnStep0, ref int pnStep1, ref int pnStep2, ref int pnStep3, ref int pnStep4, ref int pnStep5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetPtPDecStep(int nStep0, int nStep1, int nStep2, int nStep3, int nStep4, int nStep5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetPtPDecStep(ref int pnStep0, ref int pnStep1, ref int pnStep2, ref int pnStep3, ref int pnStep4 , ref int pnStep5, ushort wGroupIndex);
		
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_AbortMotion(ushort wGroupIndex, bool bAfterCurCmd);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_CheckDelay(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetErrorCount(ref int pnErrCount0, ref int pnErrCount1, ref int pnErrCount2, ref int pnErrCount3, ref int pnErrCount4, ref int pnErrCount5, ushort wCardIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetGoHomeAccTime(double dfTime0, double dfTime1, double dfTime2, double dfTime3, double dfTime4, double dfTime5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetGoHomeAccTime(ref double pdfTime0, ref double pdfTime1, ref double pdfTime2, ref double pdfTime3, ref double pdfTime4, ref double pdfTime5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetGoHomeDecTime(double dfTime0, double dfTime1, double dfTime2, double dfTime3, double dfTime4, double dfTime5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetGoHomeDecTime(ref double pdfTime0, ref double pdfTime1, ref double pdfTime2, ref double pdfTime3, ref double pdfTime4, ref double pdfTime5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetGoHomeAccStep(int nStep0, int nStep1, int nStep2, int nStep3, int nStep4, int nStep5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetGoHomeAccStep(ref int pnStep0, ref int pnStep1, ref int pnStep2, ref int pnStep3, ref int pnStep4, ref int pnStep5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetGoHomeDecStep(int nStep0, int nStep1, int nStep2, int nStep3, int nStep4, int nStep5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetGoHomeDecStep(ref int pnStep0, ref int pnStep1, ref int pnStep2, ref int pnStep3, ref int pnStep4, ref int pnStep5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetLeaveHomeSensorSpeed(double dfSpeed0, double dfSpeed1, double dfSpeed2, double dfSpeed3, double dfSpeed4, double dfSpeed5, ushort wCardIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GoHome(double dfXSpeed, double dfYSpeed, double dfZSpeed, double dfUSpeed, double dfVSpeed, double dfWSpeed, int nXOrder, int nYOrder, int nZOrder, int nUOrder, int nVOrder, int nWOrder, ushort wCardIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInPosCheckTime(ushort wCheckTime, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetInPosStableTime(ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern int     MCC_SetInPosTolerance(long lTolerance0, long lTolerance1, long lTolerance2, long lTolerance3, long lTolerance4, long lTolerance5, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern int     MCC_GetInPosTolerance(ref long plTolerance0, ref long plTolerance1, ref long plTolerance2, ref long plTolerance3, ref long plTolerance4, ref long plTolerance5, ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern double  MCC_SetOverSpeed(double dfRate, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetOverSpeed(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_SetPtPOverSpeed(double dfRate, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_GetPtPOverSpeed(ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_ChangeFeedSpeed(double dfSpeed, ushort wGroupIndex);
		[ DllImport( LibNameVersion )]
		public static extern double  MCC_ChangePtPSpeed(ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern int	 MCC_EnqueueCallback(IntPtr pfnCallbackRoutine, int nID, long lParam, ulong wParam, ushort wGroupIndex);

		[ DllImport( LibNameVersion )]
		public static extern void    MCC_LockAccessGroup();
	
		[ DllImport( LibNameVersion )]
		public static extern void    MCC_UnlockAccessGroup();

		[ DllImport( LibNameVersion )]
		public static extern void    MCC_SetCondition(int nIndex, int bOnAndOff);

		
			

	}
}