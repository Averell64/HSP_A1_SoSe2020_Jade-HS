   M S B A M L   `   `   `  ����P  LWpfApp_Sprint1_HSP_A1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApp_Sprint1_HSP_A1WpfApp_Sprint1_HSP_A1  5   	   +    %WpfApp_Sprint1_HSP_A1.EingabeRechteck   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfApp_Sprint1_HSP_A1     5   	     � Title$  	Berechnen��5   	   $	��532��6   $	��539��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J   .��5	      � .+�5
   
   �� -   5        $��
Hauptmenü��5
      $��	0,0,50,49q�6%   $��Right=�6M   $	��178��6i   $��50��6u   $��Bottom=�6�    � Cursor$
 Hand��6�   �� 5   
   -   5        $��	Berechnen��5      $
��Left=�6%   $��50��6@   $��	50,0,0,49q�6L   $��Bottom=�6_   $	��178��6z    �� IsCancel . $
 Hand��6�   �� 5   
   $,��&Geben Sie die Breite des Rechtecks an:��6   $
��Left=�6A   $��32��6\   $��
25,147,0,0q�6h   $	��Top=�6|   $	��263��6�   �� 5   
   $��	Breite = ��6   $
��Left=�6$   $��25,179,0,216q�6?   $��52��6U    J� RenderTransformOrigin$ 0.454,3.236&�6`   �� 5   
   -   5         ��Name$ Breite��5      $
��Left=�6"   $��28��6=   $��
82,179,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��360��6�   $��Center=�6�   �� 5   
   $��mm��6   $
��Left=�6   $��24��68   $��453,179,0,0q�6D   $	��Top=�6Y   $��68��6q   �� 5   
   $,��&Geben Sie die Länge des Rechtecks an:��6   $
��Left=�6@   $��32��6[   $��
25,223,0,0q�6g   $	��Top=�6{   $	��263��6�   �� 5   
   $��	Länge = ��6   $
��Left=�6#   $��25,255,0,136q�6>   $��52��6T   $ 0.454,3.236&�6_   �� 5   
   -   5        $ Länge��5      $
��Left=�6!   $��28��6<   $��
82,255,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��360��6�   $��Center=�6�   �� 5   
   $��mm��6   $
��Left=�6   $��24��68   $��453,255,0,0q�6D   $	��Top=�6Y   $��68��6q   �� 5   
   $-��'Geben Sie die Stärke des Rechtecks an:��6   $
��Left=�6A   $��32��6\   $��
25,308,0,0q�6h   $	��Top=�6|   $	��263��6�   �� 5   
   $��
Stärke = ��6   $
��Left=�6$   $��25,340,0,55q�6?   $��52��6T   $ 0.454,3.236&�6_   �� 5   
   -   5        $ Stärke��5      $
��Left=�6"   $��28��6=   $��
82,340,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��360��6�   $��Center=�6�   �� 5   
   $��mm��6   $
��Left=�6   $��24��68   $��453,340,0,0q�6D   $	��Top=�6Y   $��68��6q   �� 5   
   $	��122��6   $��160.5,20,160.5,0q�6   $	��Top=�67   $��Rectangle.jpg��6O    J� OpacityMask 5      �� 5      	 �� ImageSource$	 Rectangle.jpg��6   
 j� Stretch$
 Uniform=�69   5      �� 5   
   $��Länge��6   $
��Left=�6    $��37��6;   $��185,105,0,0q�6G   $	��Top=�6\   $	��125��6t   $��Center=�6�   $��Center=�6�   �� 5   
   $��Stärke��6   $
��Left=�6!   $��37��6<   $��
317,55,0,0q�6H   $	��Top=�6\   $	��125��6t   $��Center=�6�   $��Center=�6�   �� 5   
   $��Breite��6   $
��Left=�6!   $��37��6<   $��	90,20,0,0q�6H   $	��Top=�6[   $	��125��6s   $��Center=�6   $��Center=�6�   5!      5"      