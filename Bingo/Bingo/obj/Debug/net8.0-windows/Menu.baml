   M S B A M L   `   `   `  ����@  <Bingo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BingoBingo  5   	       
Bingo.Menu   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Bingo     5   	     � Title$
  Menu��5   	   $	��543��6   $
��1000��6#    � WindowStartupLocation$ CenterScreen=�5	   	   ���#c4dafa � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      �� .+�5   
   r� -   5        $��BackgroundMusic��5       r� Source$" Music/Cool Morning - DV3.mp3?�6.    r� Volume$	 0.1Q�6T   $��2��6a    r� UnloadedBehavior$ Manual=�6�   � 5   
    � Points �    '�) ʚ; ʚ; �����#5995dd$��2��5   !   � 5   
   % �   ���! ʚ;���! ʚ;�I���#48d3e9$��2��6F   $��Center=�6Z   $	��547��6w   $	��Top=�6�   A� 5   
   $
��Left=�6   $	��399��6-   $��-115,-59,0,0q�6:   ���#2878f1$	��Top=�6_   $	��546��6w   A� 5   
   $
��Left=�6   $	��357��6-   $��-115,-63,0,0q�6:   ���#e7ca5d$	��Top=�6_   $	��515��6w    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      	 �� Angle$	 -0.412Q�6&   T� 5      5      5      �� 5   
   -   5        
 ��Name$
 BingoIMG��5      $
��Left=�6"   $	��160��6=   $	��Top=�6J   $	��300��6b   $
��Fill=�6n   $��/bingomenu.png��6}   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property �@J�Effect �� Value 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         Color$ #dcaf68��6/      
BlurRadius$ 10Q�6?      	Direction$	 200Q�6O      ShadowDepth$ 5Q�6_   5#      5$       � Triggers 5&      :� 5'       :� RoutedEvent$ Image.Loaded��6   .[�5(      �� .��5)      �� .��5+      U�  �� TargetProperty$ Width�6<    g� Duration$ 0:0:0.58D�6^    g� RepeatBehavior$ Forever��6r   \�5-   &   ��  O� KeyTime$ 0:0:0.18��6;    O� Value$	 350Q�6N    �� 	KeySpline$ 	0,1.1,1,1��6Z   �� 5.   &   $ 0:0:0.4��6;   $	 300Q�6M   $ 0.6,0,1,0.9��6Y   50      U� 52      $ Height�6<   $ 0:0:0.58D�6_   $ Forever��6s   \�54   &   �� $ 0:0:0.18��6;   $	 187Q�6N   $ 	0,1.1,1,1��6Z   �� 55   &   $ 0:0:0.4��6;   $	 160Q�6M   $ 0.6,0,1,0.9��6Y   57      W� 5>      $ (Canvas.Left)�6.    W� From -3005?   .   	 W� To 06:   $ 0:0:0.4D�5@   .   W� 5A      $ (Canvas.Top)�6.    -3005B   .    06:   $ 0:0:0.4D�5C   .   5D      5E      5F      5H      �� 5I   
   -   5        $
 Aigis��5I      $��
/aigis.png��6    �� Left$	 679��63   
 �� Top$	 300��6E   $	��225��6V   $	��278��6c   $
��Left=�6o   $��Center=�6�   ��5J      �� 5K      " ��6   .�5L      ��  �@J�Effect 5M        5N      $ Black��6/   $ 10Q�6=   $	 320Q�6M   $ 5Q�6]   5P      5Q      5S      �� 5T   
   -   5         ��Name$ displayTextCaller��5T      $
��Wrap=�5U       �� TextAlignment$ Justify=�6(   $��Center=�5V      $��Aardvark Cafe)�5W      
�������$
��Bold"�6B   $��99��6T   $��25(�6`     J� Opacity$  0Q�5X      $	 328��6    $	 232��62   $	��351��6C   $
��Left=�6O   SQSerás dirigido a una ventana que genere números binarios y letras para rellenar5Z      �� 5[   
   -   5        ! ��Name$! 	BtnCaller��5[         BotonPersonalizado#��[  5\      $��Empezar��5]      $��40(�5^      $��Segoe UI Black)�6   $	��231��5_   P   $	 304��6]   $	 153��6o   $	��390��6�   $
��Left=�6�   $��Center=�6�   �� 5`   
   -   5        $
 Circle��5`      $��/Circle_I.png��6    $	��156��67   $	 827��6D   $ 12��6V   $	��156��6f    5a      :� 5b      $ Loaded��6   .[�5c      �� .��5d      �� .��5e      W� $5 /(Image.RenderTransform).(RotateTransform.Angle)�6.    05f   .    36067   $ 0:0:5D�6@   $ Forever��6Q   5h      5i      5j      z�5l      �� 5m      " �� CenterX$" 78Q�6"   # �� CenterY$# 78Q�6/   5o      �� 5p   
   $ 19��6   $	 485��6%   $��Center=�66   $	��Top=�6S   $��30(�6k   �� 5q      -   5        .�5q   M   )'Click aquí para abrir la ventana extra5s      5t      5u      $ � 	Resources$ 5v        CallerDeslizarAbajo% �� 
TargetName  CallerDeslizarArriba  JugadorDeslizarAbajo  JugadorDeslizarArriba��%   &	       &	 �     &	 �    &	 �    �� 5x   
   .��5y      W� $% displayTextCaller��6   $ Opacity�6H    16l   $ 0:0:0.3D�6s   W� 5z      $% displayTextCaller��6   $ (Canvas.Top)�6H    3606q   $ 0:0:0.3D�6z   5{      �� 5|   
   .��5}      W� $% displayTextCaller��6   $ Opacity�6H    06l   $ 0:0:0.3D�6s   W� 5~      $% displayTextCaller��6   $ (Canvas.Top)�6H    2326q   $ 0:0:0.3D�6z   5      �� 5�   
   6   �� 5�   
   6   5�      5�      