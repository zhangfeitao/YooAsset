# YooAsset
YooAsset是一个基于Unity3D引擎的资源管理插件。

## 特点
- **强大灵活的打包系统**

  可以自定义打包策略，可以自定义冗余规则，自动分析依赖实现资源零冗余，基于资源对象的资源包依赖管理方案，避免了资源包之间循环依赖的问题。

- **安全高效的分包方案**

  基于资源对象的标签分包方案，自动对依赖资源包进行分类，避免人工维护成本。可以非常方便的实现零资源安装包，或者全量资源安装包。

- **灵活高效的加密方案**

  提供多种加密策略，可以自定义加密规则，基于Unity官方的高效解密方案。

- **基于引用计数方案**

  基于引用技术的资源管理方案，可以帮助我们实现安全的资源卸载策略，更好的对内存管理，避免资源对象冗余。还有强大的分析器可帮助发现潜在的资源泄漏问题。

- **多种模式自由切换**

  编辑器模拟模式，单机运行模式，联机运行模式。在编辑器模拟模式下，可以不构建资源包来模拟线上环境，在不修改任何代码的情况下，可以自由切换到其它模式。

- **强大安全的加载系统**

  - **异步加载和同步加载** 异步加载接口支持协程，Task，委托。支持异步加载和同步加载混合使用。

  - **边玩边下载** 在加载资源对象的时候，如果资源对象依赖的资源包在本地不存在，会自动从服务器下载到本地，然后再加载资源对象。

  - **多线程下载** 支持断点续传，自动验证下载文件，自动修复损坏文件。可以自定义下载失败重试次数，下载超时判定时间。

  - **多功能下载器** 可以按照资源标签列表创建下载器，也可以按照资源对象列表创建下载器。下载器可以设置同时下载文件数的限制，设置下载失败重试次数，多个下载器同时下载不用担心文件重复下载问题，下载器还提供了下载进度以及下载失败异常等常用接口。

- **原生格式文件管理**

  无缝衔接资源打包系统，可以很方便的实现原生文件的版本管理和下载。

- **灵活多变的版本管理**

  支持线上版本快速回退，支持区分审核版本，测试版本，线上版本，支持灰度更新及测试。

## 入门教程
1. [快速开始](https://github.com/tuyoogame/YooAsset/blob/master/Docs/QuickStart.md)
2. [全局配置](https://github.com/tuyoogame/YooAsset/blob/master/Docs/Settings.md)
3. [资源收集](https://github.com/tuyoogame/YooAsset/blob/master/Docs/AssetCollector.md)
4. [资源打包](https://github.com/tuyoogame/YooAsset/blob/master/Docs/AssetBuilder.md)
5. [资源部署](https://github.com/tuyoogame/YooAsset/blob/master/Docs/AssetDeploy.md)

## 代码教程
1. [初始化](https://github.com/tuyoogame/YooAsset/blob/master/Docs/YooAssetInit.md)
2. [资源更新](https://github.com/tuyoogame/YooAsset/blob/master/Docs/YooAssetUpdater.md)
3. [资源加载](https://github.com/tuyoogame/YooAsset/blob/master/Docs/YooAssetLoader.md)

