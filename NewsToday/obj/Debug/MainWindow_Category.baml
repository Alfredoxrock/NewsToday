   M S B A M L   `   `   `  ����D  @NewsToday, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NewsToday	NewsToday  5   	   ;"clr-namespace:NewsToday.ViewModelsNewsToday.ViewModels  5   	   #    NewsToday.MainWindow_Category   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NewsToday     5   	   2vms"clr-namespace:NewsToday.ViewModels     5   	     � Title$  Enews��5	   	   $��3222.5��6   $��1355.5��6'    � WindowState$ 	Maximized=�66    � 
ResizeMode$ NoResize=�6N    � DataContext 5
      .  (NewsToday.ViewModels.MainWindowViewModel  5   
   ��5      �� 5   
    �� ImageSource$g aC:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\Pictures\W4.jpg��6   .��5      � $
��Auto��6   .+�5   
   �� .��5      �� $
��Auto��6   .+�5      � 
�������$
��1340��6*   $
��3197��67   .+�5      �� -   5         ��Name$ Border_Background��5   1   $��3q�6   $��271,86,70,3003q�6L    J� RenderTransformOrigin$ 0.5,0.5&�6d   ._�5      �� -   5         ��Name$ Label_Category��5       $��Nothing��68   $��Center=�6J   $��Center=�6n   
�������$��Century Gothic)�6�   $��70(�6�   $��Expanded&�6�   $
��Bold"�6�   5      �� 5      $��3q�6   
���  ��
���  ��$��263,86,78,3631q�6T   $ 0.5,0.5&�6l   ._�5      �� $
��HOME��6    $��Center=�6/   $��Center=�6S   
�������$��Century Gothic)�6�   $��70(�6�   $��Expanded&�6�   $
��Bold"�6�   5      �� 5      $��ENEWS��6   $
��Left=�6,   $��
108,26,0,0q�6G   $	��Top=�6[   $	��126��6s   $��70��6   $��36(�6�   $��Dubai Medium)�6�   
���   �6�   �� 5      $
��Left=�6   $	��100��67   $��	10,10,0,0q�6D   $	��Top=�6W   $	��100��6o   $i��cC:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\Pictures\Logo.png��6{   �� 5       -   5         ��Name$ TopPanel��5       $
��Left=�6/   $��48��6J   $��
261,33,0,0q�6V   $	��Top=�6j   $
��1075��6�   
������ .+�5!      �� -   5        	 ��Name$	 Button_SignIn��5"   Y      RoundButtonTemplate#��[  6   $��48��6:   ���#fff$��LOGIN��6p   $��22(�5#      $��Century Gothic)�6   
 � Cursor$

 Hand��67    �� Left$
 -237��6E   
 �� Top$ 76��6X   $	��237��6h   
���  ��
�������6�   �� 5%      -   5        $	 Button_Home��5'   8   #��[  5&      $	��106��5'      $��48��6   ���#fff$
��HOME��6M   
���   �
������ $��28(�5(   &   $��Century Gothic)�64   $

 Hand��6P   6�   �� 5-      -   5        $	 Button_News��5/   <   #��[  5.      $	��135��5/      $��48��6   ���#fff$
��NEWS��6Q   
������ 
���   �$��28(�50      $��Century Gothic)�6   $

 Hand��6;   $	 111��6I   6[   �� 53      -   5        $	 Button_Politis��55   <   #��[  54      $	��140��55      $��48��6   ���#fff$��POLITICS��6T   
������ 
���   �$��28(�56      $��Century Gothic)�6   $	 246��6;   $

 Hand��6M   6�   �� 58      -   5        $	 Button_Opinion��5:   <   #��[  59      $	��140��5:      $��48��6   ���#fff$��OPINION��6T   
������ 
���   �$��28(�5;      $��Century Gothic)�6   $	 391��6;   $

 Hand��6M   6�   �� 5=      -	   5        $	 Button_Sports��5?   <   #��[  5>      $	��140��5?      $��48��6   ���#fff$��SPORTS��6S   
������ 
���   �$��28(�5@      $��Century Gothic)�6   $	 536��6;   $

 Hand��6M   6�   �� 5B      -
   5        $	 Button_Entertainment��5D   <   #��[  5C      $	��231��5D      $��48��6   ���#fff$��ENTERTAINMENT��6Z   
������ 
���   �$��28(�5E      $��Century Gothic)�6   $	 676��6;   $

 Hand��6M   6�   �� 5G      -   5        $	 Button_Social��5I   <   #��[  5H      $	��163��5I      $��48��6   ���#fff$��SOCIAL��6S   
������ 
���   �$��28(�5J      $��Century Gothic)�6   $	 912��6;   $

 Hand��6M   6�   5M      �� 5O      -   5         ��Name$ Listbox_articleItems��5O   r   $
��Left=�6   $

 Hand��6:   $
��2959��6�   ��.  $��
10,224,0,0q�5P      $	��Top=�6&   $
��1326��6>   $��0q�6K   $��Hidden=�6_   ��5Q      �� *NewsArticles_Category+��5S      �� 5T      .R�5U   "   � $
��1233��6'   $	��322��64   .+�5V   &   �� $
��Left=�6,   $	��302��6d   $��	12,10,0,0q�6q   $	��Top=�6�   $	��383��6�   ��6G   �� *	SourceImg+6�   �� 5W   &   $
��Wrap=�6G   
������ $��456,10,63,186q�6u   $��Century Gothic)�6�   $��30(�6�   $
��Bold"�6�   
���   ���60   �� *Title+6�   �� 5X   &   $
��Wrap=�6H   $��Century Gothic)�6\   $��26(�6x   $��456,136,92,34q�6�   ��60   �� *Byline+6�   �� 5Y   &   $
��Wrap=�6J   $��Century Gothic)�6^   $��18(�6z   
�������$��456,111,453,162q�6�   ��60   �� *
DateTime+6�   �� 5Z   &   $��Century Gothic)�6H   $��18(�6d   
�������$��693,111,217,162q�6�   ��60   �� *Author+6�   �� 5[   &   $��BY��60   $��Century Gothic)�6:   $��18(�6V   
�������$��654,111,543,162q�6v   �� 5\   &   
�������$��	0,315,0,5q�6?   $��2��6R   5]   #   5^      5a      5g      5h      5i      5j      5k      