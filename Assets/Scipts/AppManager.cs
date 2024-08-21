using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AppManager : MonoBehaviour
{
    public GameObject PrivacyPolicyUI;
    public GameObject fieldPrefabs;
    public RectTransform fieldParent;

    public Text bLevel;
    public Text bState;

    private int PrivacyPolicyInt = 0;

    List<string> headerStingsList = new List<string>();
    List<string> resultStingsList = new List<string>();

    void Start()
    {
        string _deviceModel = "Devise Model";
        string deviceModel = SystemInfo.deviceModel;

        headerStingsList.Add(_deviceModel);
        resultStingsList.Add(deviceModel);

        string _deviceName = "Device Name";
        string deviceName = SystemInfo.deviceName;

        headerStingsList.Add(_deviceName);
        resultStingsList.Add(deviceName);

        string _deviceType = "Device Type";
        string deviceType = SystemInfo.deviceType.ToString();

        headerStingsList.Add(_deviceType);
        resultStingsList.Add(deviceType);

        string _deviceUniqueIdentifier = "Device Unique Identifier";
        string deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier;

        headerStingsList.Add(_deviceUniqueIdentifier);
        resultStingsList.Add(deviceUniqueIdentifier);

        string _graphicsDeviceID = "Graphics Device ID";
        string graphicsDeviceID = SystemInfo.graphicsDeviceID.ToString();

        headerStingsList.Add(_graphicsDeviceID);
        resultStingsList.Add(graphicsDeviceID);

        string _graphicsDeviceName = "Graphics Device Name";
        string graphicsDeviceName = SystemInfo.graphicsDeviceName;

        headerStingsList.Add(_graphicsDeviceName);
        resultStingsList.Add(graphicsDeviceName);

        string _graphicsDeviceType = "Graphics Device Type";
        string graphicsDeviceType = SystemInfo.graphicsDeviceType.ToString();

        headerStingsList.Add(_graphicsDeviceType);
        resultStingsList.Add(graphicsDeviceType);

        string _graphicsDeviceVendor = "Graphics Device Vendor";
        string graphicsDeviceVendor = SystemInfo.graphicsDeviceVendor;

        headerStingsList.Add(_graphicsDeviceVendor);
        resultStingsList.Add(graphicsDeviceVendor);

        string _graphicsDeviceVendorID = "Graphics Device Vendor ID";
        string graphicsDeviceVendorID = SystemInfo.graphicsDeviceVendorID.ToString();

        headerStingsList.Add(_graphicsDeviceVendorID);
        resultStingsList.Add(graphicsDeviceVendorID);

        string _graphicsDeviceVersion = "Graphics Device Version";
        string graphicsDeviceVersion = SystemInfo.graphicsDeviceVersion;

        headerStingsList.Add(_graphicsDeviceVersion);
        resultStingsList.Add(graphicsDeviceVersion);

        string _graphicsMemorySize = "Graphics Memory Size";
        string graphicsMemorySize = SystemInfo.graphicsMemorySize.ToString();

        headerStingsList.Add(_graphicsMemorySize);
        resultStingsList.Add(graphicsMemorySize);

        string _graphicsMultiThreaded = "Graphics Multi Threaded";
        string graphicsMultiThreaded = SystemInfo.graphicsMultiThreaded.ToString();

        headerStingsList.Add(_graphicsMultiThreaded);
        resultStingsList.Add(graphicsMultiThreaded);

        string _graphicsShaderLevel = "Graphics Shader Level";
        string graphicsShaderLevel = SystemInfo.graphicsShaderLevel.ToString();

        headerStingsList.Add(_graphicsShaderLevel);
        resultStingsList.Add(graphicsShaderLevel);

        string _hasDynamicUniformArrayIndexingInFragmentShaders = "Has Dynamic Uniform Array Indexing In Fragment Shaders";
        string hasDynamicUniformArrayIndexingInFragmentShaders = SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders.ToString();

        headerStingsList.Add(_hasDynamicUniformArrayIndexingInFragmentShaders);
        resultStingsList.Add(hasDynamicUniformArrayIndexingInFragmentShaders);

        string _hasHiddenSurfaceRemovalOnGPU = "Has Hidden Surface Removal On GPU";
        string hasHiddenSurfaceRemovalOnGPU = SystemInfo.hasHiddenSurfaceRemovalOnGPU.ToString();

        headerStingsList.Add(_hasHiddenSurfaceRemovalOnGPU);
        resultStingsList.Add(hasHiddenSurfaceRemovalOnGPU);

        string _hasMipMaxLevel = "Has Mip Max Level";
        string hasMipMaxLevel = SystemInfo.hasMipMaxLevel.ToString();

        headerStingsList.Add(_hasMipMaxLevel);
        resultStingsList.Add(hasMipMaxLevel);

        string _maxCubemapSize = "Max Cubemap Size";
        string maxCubemapSize = SystemInfo.maxCubemapSize.ToString();

        headerStingsList.Add(_maxCubemapSize);
        resultStingsList.Add(maxCubemapSize);

        string _maxTextureSize = "Max Texture Size";
        string maxTextureSize = SystemInfo.maxTextureSize.ToString();

        headerStingsList.Add(_maxTextureSize);
        resultStingsList.Add(maxTextureSize);

        string _minConstantBufferOffsetAlignment = "Min Constant Buffer Off set Alignment";
        string minConstantBufferOffsetAlignment = SystemInfo.minConstantBufferOffsetAlignment.ToString();

        headerStingsList.Add(_minConstantBufferOffsetAlignment);
        resultStingsList.Add(minConstantBufferOffsetAlignment);

        string _npotSupport = "Non Power of Dot Support";
        string npotSupport = SystemInfo.npotSupport.ToString();

        headerStingsList.Add(_npotSupport);
        resultStingsList.Add(npotSupport);

        string _operatingSystem = "operating System";
        string operatingSystem = SystemInfo.operatingSystem;

        headerStingsList.Add(_operatingSystem);
        resultStingsList.Add(operatingSystem);

        string _operatingSystemFamily = "Operating System Family";
        string operatingSystemFamily = SystemInfo.operatingSystemFamily.ToString();

        headerStingsList.Add(_operatingSystemFamily);
        resultStingsList.Add(operatingSystemFamily);

        string _processorCount = "Processor Count";
        string processorCount = SystemInfo.processorCount.ToString();

        headerStingsList.Add(_processorCount);
        resultStingsList.Add(processorCount);

        string _processorFrequency = "Processor Frequency";
        string processorFrequency = SystemInfo.processorFrequency.ToString();

        headerStingsList.Add(_processorFrequency);
        resultStingsList.Add(processorFrequency);

        string _processorType = "Processor Type";
        string processorType = SystemInfo.processorType;

        headerStingsList.Add(_processorType);
        resultStingsList.Add(processorType);

        string _supportedRenderTargetCount = "Supported Render Target Count";
        string supportedRenderTargetCount = SystemInfo.supportedRenderTargetCount.ToString();

        headerStingsList.Add(_supportedRenderTargetCount);
        resultStingsList.Add(supportedRenderTargetCount);

        string _supports2DArrayTextures = "Supports 2D Array Textures";
        string supports2DArrayTextures = SystemInfo.supports2DArrayTextures.ToString();

        headerStingsList.Add(_supports2DArrayTextures);
        resultStingsList.Add(supports2DArrayTextures);
        
        string _supports32bitsIndexBuffer = "Supports 32bits Index Buffer";
        string supports32bitsIndexBuffer = SystemInfo.supports32bitsIndexBuffer.ToString();

        headerStingsList.Add(_supports32bitsIndexBuffer);
        resultStingsList.Add(supports32bitsIndexBuffer);

        string _supports3DRenderTextures = "Supports 3D Render Textures";
        string supports3DRenderTextures = SystemInfo.supports3DRenderTextures.ToString();

        headerStingsList.Add(_supports3DRenderTextures);
        resultStingsList.Add(supports3DRenderTextures);

        string _supports3DTextures = "Supports 3D Textures";
        string supports3DTextures = SystemInfo.supports3DTextures.ToString();

        headerStingsList.Add(_supports3DTextures);
        resultStingsList.Add(supports3DTextures);

        string _supportsAccelerometer = "Supports Accelerometer";
        string supportsAccelerometer = SystemInfo.supportsAccelerometer.ToString();

        headerStingsList.Add(_supportsAccelerometer);
        resultStingsList.Add(supportsAccelerometer);

        string _supportsAsyncCompute = "Supports Async Compute";
        string supportsAsyncCompute = SystemInfo.supportsAsyncCompute.ToString();

        headerStingsList.Add(_supportsAsyncCompute);
        resultStingsList.Add(supportsAsyncCompute);

        string _supportsAsyncGPUReadback = "Supports Async GPU Readback";
        string supportsAsyncGPUReadback = SystemInfo.supportsAsyncGPUReadback.ToString();

        headerStingsList.Add(_supportsAsyncGPUReadback);
        resultStingsList.Add(supportsAsyncGPUReadback);

        string _supportsAudio = "Supports Audio";
        string supportsAudio = SystemInfo.supportsAudio.ToString();

        headerStingsList.Add(_supportsAudio);
        resultStingsList.Add(supportsAudio);

        string _supportsComputeShaders = "Supports Compute Shaders";
        string supportsComputeShaders = SystemInfo.supportsComputeShaders.ToString();

        headerStingsList.Add(_supportsComputeShaders);
        resultStingsList.Add(supportsComputeShaders);

        string _supportsCubemapArrayTextures = "Supports Cubemap Array Textures";
        string supportsCubemapArrayTextures = SystemInfo.supportsCubemapArrayTextures.ToString();

        headerStingsList.Add(_supportsCubemapArrayTextures);
        resultStingsList.Add(supportsCubemapArrayTextures);

        string _supportsGyroscope = "Supports Gyroscope";
        string supportsGyroscope = SystemInfo.supportsGyroscope.ToString();

        headerStingsList.Add(_supportsGyroscope);
        resultStingsList.Add(supportsGyroscope);
        
        string _supportsHardwareQuadTopology = "Supports Hardware Quad Topology";
        string supportsHardwareQuadTopology = SystemInfo.supportsHardwareQuadTopology.ToString();

        headerStingsList.Add(_supportsHardwareQuadTopology);
        resultStingsList.Add(supportsHardwareQuadTopology);

        string _supportsInstancing = "Supports Instancing";
        string supportsInstancing = SystemInfo.supportsInstancing.ToString();

        headerStingsList.Add(_supportsInstancing);
        resultStingsList.Add(supportsInstancing);

        string _supportsLocationService = "Supports Location Service";
        string supportsLocationService = SystemInfo.supportsLocationService.ToString();

        headerStingsList.Add(_supportsLocationService);
        resultStingsList.Add(supportsLocationService);

        string _supportsMipStreaming = "Supports Mip Streaming";
        string supportsMipStreaming = SystemInfo.supportsMipStreaming.ToString();

        headerStingsList.Add(_supportsMipStreaming);
        resultStingsList.Add(supportsMipStreaming);

        string _supportsMotionVectors = "Supports Motion Vectors";
        string supportsMotionVectors = SystemInfo.supportsMotionVectors.ToString();

        headerStingsList.Add(_supportsMotionVectors);
        resultStingsList.Add(supportsMotionVectors);

        string _supportsMultisampleAutoResolve = "Supports Multisample Auto Resolve";
        string supportsMultisampleAutoResolve = SystemInfo.supportsMultisampleAutoResolve.ToString();

        headerStingsList.Add(_supportsMultisampleAutoResolve);
        resultStingsList.Add(supportsMultisampleAutoResolve);

        string _supportsMultisampledTextures = "Supports Multisampled Textures";
        string supportsMultisampledTextures = SystemInfo.supportsMultisampledTextures.ToString();

        headerStingsList.Add(_supportsMultisampledTextures);
        resultStingsList.Add(supportsMultisampledTextures);

        string _supportsRawShadowDepthSampling = "Supports Raw Shadow Depth Sampling";
        string supportsRawShadowDepthSampling = SystemInfo.supportsRawShadowDepthSampling.ToString();

        headerStingsList.Add(_supportsRawShadowDepthSampling);
        resultStingsList.Add(supportsRawShadowDepthSampling);

        string _supportsSetConstantBuffer = "Supports Set Constant Buffer";
        string supportsSetConstantBuffer = SystemInfo.supportsSetConstantBuffer.ToString();

        headerStingsList.Add(_supportsSetConstantBuffer);
        resultStingsList.Add(supportsSetConstantBuffer);

        string _supportsShadows = "Supports Shadows";
        string supportsShadows = SystemInfo.supportsShadows.ToString();

        headerStingsList.Add(_supportsShadows);
        resultStingsList.Add(supportsShadows);

        string _supportsSparseTextures = "Supports Sparse Textures";
        string supportsSparseTextures = SystemInfo.supportsSparseTextures.ToString();

        headerStingsList.Add(_supportsSparseTextures);
        resultStingsList.Add(supportsSparseTextures);

        string _supportsVibration = "Supports Vibration";
        string supportsVibration = SystemInfo.supportsVibration.ToString();

        headerStingsList.Add(_supportsVibration);
        resultStingsList.Add(supportsVibration);

        string _systemMemorySize = "System Memory Size";
        string systemMemorySize = SystemInfo.systemMemorySize.ToString();

        headerStingsList.Add(_systemMemorySize);
        resultStingsList.Add(systemMemorySize);

        GenerateFeild();
    }

    void GenerateFeild()
    {
        for (int i = 0; i < headerStingsList.Count; i++)
        {
            GameObject instantiatedField = Instantiate(fieldPrefabs, (fieldParent.gameObject.GetComponent<RectTransform>()) );

            //DarkBackground/ HeaderInfoText
            //DarkBackground/ InfosValue

            Transform tHeader = instantiatedField.transform.Find("HeaderInfoText");
            Transform tInfo = instantiatedField.transform.Find("InfosValue");

            Text tHeaderText = tHeader.GetComponent<Text>();
            Text tInfoText = tInfo.GetComponent<Text>();

            tHeaderText.text = headerStingsList[i];
            tInfoText.text = resultStingsList[i];
        }

        PrivacyPolicyInt = PlayerPrefs.GetInt("PrivacyPolicyMessage");

        if (PrivacyPolicyInt == 0)
        {
            PrivacyPolicyUI.SetActive(true);
            PlayerPrefs.SetInt("PrivacyPolicyMessage", 1);
        }
    }

    void Update()
    {
        string batteryLevel = (SystemInfo.batteryLevel * 100f).ToString();
        bLevel.text = batteryLevel + " %";
        string batteryStatus = SystemInfo.batteryStatus.ToString();
        bState.text = batteryStatus;
    }
}