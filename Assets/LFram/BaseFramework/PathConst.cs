﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathConst
{
	/* ----------------------------------------AB包路径------------------------------------------------ */
	//AB配置表名字
	public static string ABCONFIG_NAME = "AssetBundleConfig";
	//ABConfig表所在的AB包名字
	public static string ABCONFIG_ABNAME = "abconfig";

	//[AB包配置路径表]路径
	public static string ABCONFIG_PATH = "Assets/LFram.Editor/Editor/Resource/ABConfig.asset";
	
	//[AB包]打包出来的路径
	public static string BUNDLE_TARGET_PATH = Application.dataPath + "/../AssetBundle/";

	//[ABConfig.XML] 生成路径
	public static string ABCONFIG_XML_PATH = "Assets/ABData/AssetBundleConfig.xml"; 

	//[ABConfig.bytes] 生成路径
	public static string ABCONFIG_BYTES_PATH = "Assets/ABData/AssetBundleConfig.bytes"; 

	//[ABConfig.ab] config包的加载路径
	public static string ABCONFIG_LOAD_PATH = GetReadABPath();



	/* ------------------------------------------UI及特效路径---------------------------------------------------- */

	//UI所在路径
	public static string UI_PATH = "Assets/GameData/Prefabs/UI";

	//特效所在路径
	public static string EFFECT_PATH = "Assets/GameData/Prefabs/Effect";

	//UI路径
	public static string UI_PANEL_PATH = "Assets/GameData/Prefabs/UI/";



	/* --------------------------------------------Excel配置表路径-------------------------------------------------- */

	//[配置表]文件存放路径
	public static string CONFIG_PATH = "Assets/GameData/Data/";

	//[配置表]XML文件存放文件夹
	public static string XML_DIR = "Xml";
	
	//[配置表]二进制文件存放文件夹
	public static string BINARY_DIR = "Binary";

	//[配置表]配置表类存放路径
	public static string CONFIG_DATA_PATH = "Assets/Scripts/Config/";

    //Excel路径
    public static string EXCEL_PATH = Application.dataPath + "/../ConfigData/Excel/";

    //Reg中间XML路径
    public static string REG_PATH = Application.dataPath + "/../ConfigData/Reg/";



    /* ------------------------------------------加载参数设置----------------------------------------------------------- */

    //是否从AssetBundle进行加载
    public static bool LoadFromAssetBundle = false;

	//异步资源加载 分帧延时[单位微秒]
	public static long MAX_LOADRESOURCE_TIME = 200000;

	//ResourceManager最大缓存个数
	public static int MAX_CACHE_COUNT = 500;




	/* ------------------------------------------其他相关------------------------------------------------------------ */

	/// <summary>
	/// 根据平台获取对应文件夹
	/// </summary>
	public static string GetDirPlatform()
	{
		switch (Application.platform)
		{
			case RuntimePlatform.Android: return "Android";
			case RuntimePlatform.IPhonePlayer: return "IOS";
			case RuntimePlatform.WindowsEditor: 
			case RuntimePlatform.WindowsPlayer: return "Windows";
		}
		return "";
	}

	/// <summary>
	/// 获取AB包读取路径
	/// </summary>
	public static string GetReadABPath()
	{
#if UNITY_EDITOR
	return Application.dataPath + "/../AssetBundle/" + GetDirPlatform() + "/";
#else
	return Application.streamingAssetsPath + "/" + GetDirPlatform() + "/";
#endif
	}
}



/// <summary>
/// 资源加载优先级
/// </summary>
public enum LoadResPriority
{
	RES_HIGHT = 0,	// 最高优先级	
	RES_MIDDLE,		// 中优先级
	RES_SLOW,		// 低优先级
	RES_NUM			// 优先级个数
}
