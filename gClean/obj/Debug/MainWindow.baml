   M S B A M L   `   `   `  ����I  EXamlFlair.WPF, Version=1.2.13.0, Culture=neutral, PublicKeyToken=null<.clr-namespace:XamlFlair;assembly=XamlFlair.WPF	XamlFlair  5   	   A =gClean, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:gCleangClean 5   	      gClean.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   7xf.clr-namespace:XamlFlair;assembly=XamlFlair.WPF  5   	    localclr-namespace:gClean  5   	   -   5          � Title$  gClean��5
   	   $��304.898��6   $	��370��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$ SingleBorderWindow=�6K   ���	#FF252525.��5      � ���	#FF191818 J� RenderTransformOrigin$ 0.501,0.527&�6"    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   "  FontAwesome.WPF.ImageAwesome     Icon$
 Cogs=�6   $��296,192,18,23q�6&      
Foreground
 ����� J� Opacity$	 0.1Q�6P   $ 0.349,0.197&�6^   �� 5   
   -   5        $��Clean��5      $
��Left=�6!   $��
28,178,0,0q�6<   $	��Top=�6P   $	��257��6h   $��60��6t   ���	#FF363636$
��Bold"�6�   
�������$��16(�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 	#FF191919��6#    � Offset$ 0Q�65   � 5      $
 	#FF252525��6#   $ 1Q�65   5      5        5   
   $ 
FolderOpen=�6   $��20,138,310,94q�6,   
 �����$	 0.1Q�6V   �� 5   
   $��gClean��6   $��108,10,106,0q�6!   $	��Top=�67   
�������$��41(�6b   $��70��6p   $
��Bold"�6|   �� 5   
   -   5         ��Name$ textbox��5      $
��Left=�6#   $��29��6>   $��
54,142,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $(��"Your G-Mod Path (ex. C:\garrysmod)��6�   $	��Top=�6�   $	��231��6�   ���	#FF747474 �� SelectionBrush �	#FF2E8CDA$��10(�68  ��6�   Z� ��6!  Z� 6F  �� 5   
   $,��&"glorified gmod FactoryReset-GMOD.bat"��6   $
��Left=�6K   $��	41,80,0,0q�6f   $	��Top=�6y   ���	#FF747474$��Italic$�6�   $��30��6�   $	��294��6�   $��Center=�6�   �� 5   
   -   5        $��Settings��5      $
��Left=�6$   $��292,187,0,0q�6?   $	��Top=�6T   $��52��6l   $��49��6w   $	 0.1Q�6�   ��6�   Z� ��6�   Z� ��6�   Z� 6�   �� 5   
   $
��v1.2��6   $
��Left=�6   $��115,41,-38,0q�6:   $	��Top=�6P   ���	#FF747474$��Italic$�6   $��30��6�   $	��287��6�   $��Center=�6�   $��2��6�   $
��Bold"�6�   �� 5    
   -   5         ��Name$
 cbox��5       $-��'Also clean /addons folder (Recommended)��6!   $
��Left=�6S   $��
28,243,0,0q�6n   $	��Top=�6�   ���	#FF747474 d� 	IsChecked$
 TrueY�6�   5!      5"      