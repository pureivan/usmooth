﻿# usmooth

- [__Download (v0.1.2r)__](https://github.com/SeaSunOpenSource/usmooth/releases/tag/0.1.2r)  
- [__Tutorial__](https://github.com/SeaSunOpenSource/usmooth/wiki/tutorial)
- [Release Notes](/release_notes.md)
- [Roadmap](https://github.com/SeaSunOpenSource/usmooth/milestones/0.2)

## 设计目标

Unity 已有的性能剖析机制已经很强大了，可是它主要以程序员为目标用户，缺乏对美术和测试等非程序员的支持。而 usmooth 的目的在于帮助__非程序员__提高对游戏实时性能的消耗情况的理解，帮助美术更好地去做场景/角色/特效等资源的规划。

## 功能列表

- (连通性) 可通过 wifi 连接到手机或 Unity Editor 内正在运行的 App 
- (数据分析) 可显示当前屏幕可见的 Mesh / Material / Texture 三级信息列表
- (数据统计和排序) 所有列表中的信息都是可排序的，在 Texture 一栏可查到每张贴图的实际内存开销
- (依赖关系) 当双击这三个列表中的任意一项时，所有依赖项和被依赖项都会浅绿色高亮显示
- (编辑器互动) 使用 “定位物件” 功能可在编辑器的场景视图内定位并查看当前选中的物件
- (编辑器互动) 当在编辑器的场景视图内选中物件时，在 usmooth 内所有对应的依赖项都会浅蓝色高亮显示

## 运行情况截图

![running_screen](https://github.com/SeaSunOpenSource/usmooth/wiki/images/running_screen.png?raw=true)


