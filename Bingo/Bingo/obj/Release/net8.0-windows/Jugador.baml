   M S B A M L   `   `   `  ���� @  <Bingo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BingoBingo      Bingo.Jugador   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Bingo       � Title$  Bingo�� � AllowsTransparency$
 True��
������ $	��768��$
��1360�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � 	Resources    DesaparecerCanvas �� TargetProperty	 W� To	 g� Duration��%9   &	        �� .��W� $ Opacity� 0$	 0:0:0.9D�.���� -   $��canvas��.+�� $	��768��$
��1360�����#fbe81b
 � Triggers
 :�  :� RoutedEvent$ WrapPanel.Loaded��.[��� .���� .��W� $ Opacity� W� From 0 0.9$	 0:0:0.3D��� -    ��Name$ 
IMGLineRed��$��/WallpaperLR.png�� �� Left$	 320��
 �� Top$	 -40��$��Center=�$	��Top=�$
��1258��$��14��
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)�	 -1300 -138$	 0:0:0.4D��� -   $ IMGLineG��$��/WallpaperLG.png��$��Center=�$	 276��$	��Top=�$ 0��$��40��$
��1148��
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)� 1200 0  $	 0:0:0.6D��� -   $ IMGLineB��$��/WallpaperLB.png��$	 472��$ 0��$
��Left=�$��Center=�$��32��
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)�	 -1200 0$	 0:0:0.2D��� -   $ IMGLineC_Copiar��$��/WallpaperLC.png��$��Center=�$	 497��$	��Top=�$
��1149��$��16��$	 -24��
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)� 1250 -24$	 0:0:0.5D��� -   $ IMGLineB_Copiar��$��/WallpaperLB.png��$	 510��$��23��$��Center=�$	��Top=�$
��Fill=�$
��1080��
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)�	 -1200 0$	 0:0:0.2D��� -   $ IMGLineY��$��/WallpaperLY.png��$��Center=�$	 371��$ 0��$	��Top=�$��35��$
��1125��$
��Fill=�
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)�	 -1250 0$	 0:0:0.2D��� -   $ IMGLineC��$��/WallpaperLC.png��$
��Left=�$	 355��$��Center=�$
��1149��$��16��$	 -24��
 :� $ Image.Loaded��.[��� .���� .��W� $ (Canvas.Top)� 1250 -24$	 0:0:0.5D��� $	��186��$	��188��$��/UPN.png��$
��Left=�$	��Top=�$ 10��$
 1134������  �� 
TargetType" ��.���  �� Property �@J�Effect �� Value 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ White��   
BlurRadius$ 50Q�   	Direction$	 250Q�   ShadowDepth$ 10Q��� -	    ��Name$ MensajeDeAviso��$��30(�
���  ��$��Swis721 BlkCn BT)�$��Center=�$	��Top=�$	 -51��$	 610��.��<:Recomendación: Escribe las letras faltantes en mayúscula
 :� $ Label.Loaded��.[��� .���� .��W� $ (Canvas.Top)� 0$	 0:0:0.3D��� -
    ��Name$ XD��$	��395��$	��224��$	 970��$	 554��$��	Verificar��  EstiloAmarillo#��[ $
��Left=�$	��Top=�$��Segoe UI Black)��� -   $ IMGTabla��$	��288��$	 894��$ 81��$	��215��$��/tablaASCII.jpg��$
��Left=�$	��Top=� J� Opacity$	 0.4Q�
 :� $ UIElement.MouseEnter��.[��� .���� .��W� $ Height� 538$	 0:0:0.3D�W� $ Width� 400$	 0:0:0.3D�W� $ Opacity� 0.9$	 0:0:0.3D�:� $ UIElement.MouseLeave��.[��� .���� .��W� $ Height� 289$	 0:0:0.3D�W� $ Width� 215$	 0:0:0.3D�W� $ Opacity� 0.3$	 0:0:0.3D�