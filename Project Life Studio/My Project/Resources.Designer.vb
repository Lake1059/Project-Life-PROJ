﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PLS.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  重写当前线程的 CurrentUICulture 属性，对
        '''  使用此强类型资源类的所有资源查找执行重写。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似 Steamworks已连接=已连接到 Steam：
        '''Steamworks未连接=无法连接到 Steam
        '''
        '''
        '''
        '''功能显示名称描述=此处更改游戏内各项功能所显示的名称&lt;br&gt;&lt;br&gt;例如你想做 Stellaris 那样的世界观，可以把殖民地改为星球，把载具改为舰船&lt;br&gt;&lt;br&gt;或者描绘像 Frostpunk 那样的场景，可以把殖民地改为定居点等
        '''通用统计资源描述=通用统计资源显示在每个殖民地概览中的资源存量视图中&lt;br&gt;&lt;br&gt;这直观反映了殖民地的主要产出，诸如像电力、水资源、食物配给等&lt;br&gt;&lt;br&gt;世界内的通用货币也需要通过这种方式添加，常用的名词有金币、信用点等&lt;br&gt;&lt;br&gt;当然像木材、石材、矿物等可以放在仓库里吃灰的材料请放到物品系统里&lt;br&gt;&lt;br&gt;要留意游戏和模组作者所定义的资源 ID，这样你才能操作那些资源
        '''殖民地系统描述=殖民地系统的设计与 Stellaris 中的星球相似，包括物种、区划、建筑、决议等&lt;br&gt;&lt;br&gt;除此之外还可以访问其他功能以及区域，例如农田、餐厅、酒馆、放映室等&lt;br&gt;&lt;br&gt;一旦殖民地被发现并维持存在就会一直占用游戏刻计算性能，游戏可以使用多线程来降低计算 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property SimplifiedChinese() As String
            Get
                Return ResourceManager.GetString("SimplifiedChinese", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
