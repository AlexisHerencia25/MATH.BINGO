   M S B A M L   `   `   `  ���� @  <Bingo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BingoBingo      
Bingo.Menu   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Bingo       � Title$
  Menu��$	��543��$
��1000�� � WindowStartupLocation$ CenterScreen=����#c4dafa � 
ResizeMode$ NoResize=� � WindowState$ Normal=�.���� .+�r� -   $��BackgroundMusic�� r� Source$" Music/Cool Morning - DV3.mp3?� r� Volume$	 0.1Q�$��2�� r� UnloadedBehavior$ Manual=��  � Points �    '�) ʚ; ʚ; �����#5995dd$��2��� % �   ���! ʚ;���! ʚ;�I���#48d3e9$��2��$��Center=�$	��547��$	��Top=�A� $
��Left=�$	��399��$��-115,-59,0,0q����#2878f1$	��Top=�$	��546��A� $
��Left=�$	��357��$��-115,-63,0,0q����#e7ca5d$	��Top=�$	��515�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� 	 �� Angle$	 -0.412Q�T� �� -   
 ��Name$
 BingoIMG��$
��Left=�$	��160��$	��Top=�$	��300��$
��Fill=�$��/bingomenu.png������  �� 
TargetType" ��.���  �� Property �@J�Effect �� Value 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ #dcaf68��   
BlurRadius$ 10Q�   	Direction$	 200Q�   ShadowDepth$ 5Q� � Triggers :�  :� RoutedEvent$ Image.Loaded��.[��� .���� .��U�  �� TargetProperty$ Width� g� Duration$ 0:0:0.58D� g� RepeatBehavior$ Forever��\���  O� KeyTime$ 0:0:0.18�� O� Value$	 350Q� �� 	KeySpline$ 	0,1.1,1,1���� $ 0:0:0.4��$	 300Q�$ 0.6,0,1,0.9��U� $ Height�$ 0:0:0.58D�$ Forever��\��� $ 0:0:0.18��$	 187Q�$ 	0,1.1,1,1���� $ 0:0:0.4��$	 160Q�$ 0.6,0,1,0.9��W� $ (Canvas.Left)� W� From -300	 W� To 0$ 0:0:0.4D�W� $ (Canvas.Top)� -300 0$ 0:0:0.4D��� -   $
 Aigis��$��
/aigis.png�� �� Left$	 679��
 �� Top$	 300��$	��225��$	��278��$
��Left=�$��Center=����� " ��.���  �@J�Effect   $ Black��$ 10Q�$	 320Q�$ 5Q��� -    ��Name$ displayTextCaller��$
��Wrap=� �� TextAlignment$ Justify=�$��Center=�$��Aardvark Cafe)�
�������$
��Bold"�$��99��$��25(�  J� Opacity$  0Q�$	 328��$	 232��$	��351��$
��Left=�SQSerás dirigido a una ventana que genere números binarios y letras para rellenar�� -   ! ��Name$! 	BtnCaller��   BotonPersonalizado#��[  $��Empezar��$��40(�$��Segoe UI Black)�$	��231��$	 304��$	 153��$	��390��$
��Left=�$��Center=��� -   $
 Circle��$��/Circle_I.png��$	��156��$	 827��$ 12��$	��156�� :� $ Loaded��.[��� .���� .��W� $5 /(Image.RenderTransform).(RotateTransform.Angle)� 0 360$ 0:0:5D�$ Forever��z��� " �� CenterX$" 78Q�# �� CenterY$# 78Q��� $ 19��$	 485��$��Center=�$	��Top=�$��30(��� -   .�)'Click aquí para abrir la ventana extra$ � 	Resources$   CallerDeslizarAbajo% �� 
TargetName  CallerDeslizarArriba  JugadorDeslizarAbajo  JugadorDeslizarArriba��%L  &	       &	 �     &	     &	     �� .��W� $% displayTextCaller��$ Opacity� 1$ 0:0:0.3D�W� $% displayTextCaller��$ (Canvas.Top)� 360$ 0:0:0.3D��� .��W� $% displayTextCaller��$ Opacity� 0$ 0:0:0.3D�W� $% displayTextCaller��$ (Canvas.Top)� 232$ 0:0:0.3D��� �� 