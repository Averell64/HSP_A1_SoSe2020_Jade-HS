   M S B A M L   `   `   `  ����P  LWpfApp_Sprint1_HSP_A1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfApp_Sprint1_HSP_A1WpfApp_Sprint1_HSP_A1  5      /    )WpfApp_Sprint1_HSP_A1.EingabeHohlprofil_R   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WpfApp_Sprint1_HSP_A1     5        � Title$  
Berechnung��5      $��536.968��6   $��558.456��6+   .��5
      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ textBox1��5      $��23��6$   $��267,213,98,0q�60    �� TextWrapping$
 Wrap=�6F   $	��Top=�6[   .��6s    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.5Q�6#   .��5      5      �� 5   
   -   5        $ textBox2��5      $��23��6$   $��267,261,98,0q�60   $
 Wrap=�6F   $	��Top=�6[   .��6s    5        5      $	 0.5Q�6#   .��5      5      �� 5   
   -   5        $ textBox3��5      $��23��6$   $��267,307,98,0q�60   $
 Wrap=�6F   $	��Top=�6[   .��6s    5        5      $	 0.5Q�6#   .��5      5      �� 5   
   -   5        $��	Berechnen��5      $
��Left=�6%   $��	50,0,0,50q�6@   $	��196��6S   $��78��6v   $��Bottom=�6�   $��18(�6�   ���	#FFB2AEAE � UseLayoutRounding .   5        5         
BlurRadius$ 10Q�6#      ShadowDepth$ 10Q�63   $	 0.7Q�6D   5!      �� 5"   
   -   5        $��
Hauptmenü��5"      $��	0,0,50,50q�6%   $��Right=�6M   $	��196��6i   $��78��6u   $��Bottom=�6�   $��18(�6�   ���	#FFB2AEAE 5#        5$      $ 10Q�6#   $ 10Q�63   $	 0.7Q�6D   5&      �� 5'   
   $��Durchmesser Da��6   $
��Left=�6)   $��
72,206,0,0q�6D   $	��Top=�6X   $��16(�6p   ��6~   Z�  5(        5)      $	 0.5Q�6#   5+      �� 5,   
   $��Durchmesser Di��6   $
��Left=�6)   $��
72,262,0,0q�6D   $	��Top=�6X   $��16(�6p   ��6~   Z�  5-        5.      $	 0.5Q�6#   50      �� 51   
   $��Länge L��6   $
��Left=�6"   $��123,308,0,0q�6=   $	��Top=�6R   $��16(�6j   $��75��6�   ��6x   Z�  52        53      $	 0.5Q�6#   55      �� 56   
   $��mm��6   $
��Left=�6   $��477,205,0,0q�68   $	��Top=�6M   $��16(�6e   ��6s   Z�  57        58      $	 0.5Q�6#   5:      �� 5;   
   $��mm��6   $
��Left=�6   $��477,253,0,0q�68   $	��Top=�6M   $��16(�6e   ��6s   Z�  5<        5=      $	 0.5Q�6#   5?      �� 5@   
   $��mm��6   $
��Left=�6   $��477,299,0,0q�68   $	��Top=�6M   $��16(�6e   ��6s   Z�  5A        5B      $	 0.5Q�6#   5D      �� 5E   
   -   5        	 ��Name$	 Image��5E      $
��Left=�6   $	��180��6:   $��
139,21,0,0q�6G   $	��Top=�6[   $	��265��6s   $��Rund_Hohlprofil.jpg��6   $
��Fill=�6�   
 J� OpacityMask
 5F      �� 5G       �� ImageSource$ Rund_Hohlprofil.jpg��6   5I      5J      5L      