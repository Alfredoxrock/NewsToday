   M S B A M L   `   `   `  ����D  @NewsToday, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NewsToday	NewsToday  5   	   ;"clr-namespace:NewsToday.ViewModelsNewsToday.ViewModels  5   	       NewsToday.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NewsToday     5   	   2vms"clr-namespace:NewsToday.ViewModels     5   	     � Title$  Enews��5	   	   $��3863.5��6   $��1355.5��6'    � WindowState$ 	Maximized=�66    � 
ResizeMode$ NoResize=�6N    � DataContext 5
      .  (NewsToday.ViewModels.MainWindowViewModel  5   
   ��5      �� 5   
    �� ImageSource$g aC:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\Pictures\W4.jpg��6   .��5      � $
��Auto��6   .+�5   
   �� .��5      �� $
��Auto��6   .+�5      � 
�������$
��1340��6*   $
��3831��67   .+�5      �� $��3q�6   
���  ��
���  ��$��263,86,78,3631q�6T    J� RenderTransformOrigin$ 0.5,0.5&�6l   ._�5      �� $
��HOME��6    $��Center=�6/   $��Center=�6S   
�������$��Century Gothic)�6�   $��70(�6�   $��Expanded&�6�   $
��Bold"�6�   5      �� 5      
���   �
���  ��$��0q�6B   $
��Left=�6V   $��2��6q   $��
10,843,0,0q�6|   $	��Top=�6�   $
��1320��6�   �� 5      $��ENEWS��6   $
��Left=�6,   $��
108,26,0,0q�6G   $	��Top=�6[   $	��126��6s   $��70��6   $��36(�6�   $��Dubai Medium)�6�   
���   �6�   �� 5      $
��Left=�6   $	��100��67   $��	10,10,0,0q�6D   $	��Top=�6W   $	��100��6o   $i��cC:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\Pictures\Logo.png��6{   �� 5      -   5         ��Name$ TopPanel��5      $
��Left=�6/   $��48��6J   $��
261,33,0,0q�6V   $	��Top=�6j   $
��1075��6�   
������ .+�5      �� -   5         ��Name$ Button_SignIn��5    Y      RoundButtonTemplate#��[  6   $��48��6:   ���#fff$��LOGIN��6p   $��22(�5!      $��Century Gothic)�6    � Cursor$
 Hand��67   	 �� Left$
	 -237��6E   

 �� Top$
 76��6X   $	��237��6h   
���  ��
�������6�   �� 5#      -   5        $ Button_Home��5%   8   #��[  5$      $	��106��5%      $��48��6   ���#fff$
��HOME��6M   
���   �
������ $��28(�5&   &   $��Century Gothic)�64   $
 Hand��6P   6�   �� 5+      -   5        $ Button_News��5-   <   $
 Hand��5+   !   #��[  5,      $	��135��5-      $��48��6   ���#fff$
��NEWS��6Q   
������ 
���   �$��28(�5.      $��Century Gothic)�6   $		 111��6;   6�   �� 51      -   5        $ Button_Politis��53   <   #��[  52      $	��140��53      $��48��6   ���#fff$��POLITICS��6T   
������ 
���   �$��28(�54      $��Century Gothic)�6   $		 246��6;   $
 Hand��6M   6�   �� 56      -   5        $ Button_Opinion��58   <   #��[  57      $	��140��58      $��48��6   ���#fff$��OPINION��6T   
������ 
���   �$��28(�59      $��Century Gothic)�6   $		 391��6;   $
 Hand��6M   6�   �� 5;      -   5        $ Button_Sports��5=   <   #��[  5<      $	��140��5=      $��48��6   ���#fff$��SPORTS��6S   
������ 
���   �$��28(�5>      $��Century Gothic)�6   $		 536��6;   $
 Hand��6M   6�   �� 5@      -   5        $ Button_Entertainment��5B   <   #��[  5A      $	��231��5B      $��48��6   ���#fff$��ENTERTAINMENT��6Z   
������ 
���   �$��28(�5C      $��Century Gothic)�6   $		 676��6;   $
 Hand��6M   6�   �� 5E      -	   5        $ Button_Social��5G   <   #��[  5F      $	��163��5G      $��48��6   ���#fff$��SOCIAL��6S   
������ 
���   �$��28(�5H      $��Century Gothic)�6   $		 912��6;   $
 Hand��6M   6�   5M      �� 5N      -
   5        $
 Bar1��5N   �   $
��Left=�6   $	��192��68   $��
370,81,0,0q�6E   $	��Top=�6Y   $	��246��6q   
�������.+�5O      �� -   5        $ Button_Local��5Q   <   #��[  5P      $	��245��5Q      $��51��6   ���#fff$��LOCAL��6R   
�������$
 Hand��6u   
���   �$��28(�5R   $   $��Dubai Light)�62   $
 -3��6K   6�   �� 5T      -   5        $ Button_State��5V   <   #��[  5U      $	��245��5V      $��48��6   ���#fff$��STATE��6R   
�������$
 Hand��6u   
���   �$��28(�5W   %   $��Dubai Light)�63   $
 48��6L   6�   �� 5Y      -   5        $ Button_National��5[   <   #��[  5Z      $	��245��5[      $��48��6   ���#fff$��NATIONAL��6U   
�������$
 Hand��6{   
���   �$��28(�5\   $   $��Dubai Light)�62   $
 96��6K   6�   �� 5^      -   5        $ Button_World��5`   <   #��[  5_      $	��245��5`      $��48��6   ���#fff$��WORLD��6R   
�������$
 Hand��6u   
���   �$��28(�5a   $   $��Dubai Light)�62   $	
 144��6K   6�   5c      �� 5d      -   5         ��Name$ Listbox_articleItems��5d   r   $
��Left=�6   $
 Hand��6:   $
��2959��6�   ��.  $��
10,872,0,0q�5e      $	��Top=�6&   $
��1326��6>   $��0q�6K   $��Hidden=�6_   ��5f      �� *NewsArticles+��5h      �� 5i      .R�5j   "   � $
��1233��6'   $	��322��64   .+�5k   &   �� $
��Left=�6,   $	��302��6d   $��	12,10,0,0q�6q   $	��Top=�6�   $	��383��6�   ��6G   �� *	SourceImg+6�   �� 5l   &   $
��Wrap=�6G   
������ $��456,10,63,186q�6u   $��Century Gothic)�6�   $��30(�6�   $
��Bold"�6�   
���   ���60   �� *Title+6�   �� 5m   &   $
��Wrap=�6H   $��Century Gothic)�6\   $��26(�6x   $��456,136,92,34q�6�   ��60   �� *Byline+6�   �� 5n   &   $
��Wrap=�6J   $��Century Gothic)�6^   $��18(�6z   
�������$��456,111,453,162q�6�   ��60   �� *
DateTime+6�   �� 5o   &   $��Century Gothic)�6H   $��18(�6d   
�������$��693,111,217,162q�6�   ��60   �� *Author+6�   �� 5p   &   $��BY��60   $��Century Gothic)�6:   $��18(�6V   
�������$��654,111,543,162q�6v   �� 5q   &   
�������$��	0,315,0,5q�6?   $��2��6R   5s   #   5t      5w      �� 5y      -   5        $ Listbox_OneItemFirst��5y      $
��Left=�6<   $
 Hand��6W   $	��326��6e   $��261,218,0,0q�6r   $	��Top=�6�   $	��541��6�   ��.  $��0q�5z   D   $��Hidden=�6X   $��Hidden=�5{      ��5z   �   �� *
OneArticle+��5|      �� 5}      .R�5~   "   � $	��541��6'   $	��326��63   $��Center=�6@   $��Center=�6]   .+�5   &   �� $��Center=�6,   $��UniformToFill=�6I   ��6a   �� *	SourceImg+�� 5�   &   $��Bottom=�61   .+�5�   *   �� $
��Wrap=�6K   
�������$��Century Gothic)�6r   $��22(�6�   $
��Bold"�6�   $��Bottom=�6�   $
��15,5q�6�    �� TextAlignment$
 Left=�6�   ��64   �� *Title+6�   �� 5�   *   $
��Wrap=�6L   
�������$��Century Gothic)�6s   $��16(�6�   $
��Bold"�6�   $��Bottom=�6�   $��15,15q�6�   ��64   �� *Byline+6�   5�   '   5�   #   5�      5�      �� 5�      -   5        $ Listbox_OneItemSecond��5�      $
��Left=�6=   $
 Hand��6X   $	��163��6f   $��823,218,0,0q�6s   $	��Top=�6�   $	��438��6�   ��.  $��0q�5�   D   $��Hidden=�6X   $��Hidden=�5�      ��5�   �   �� *OneArticle2+��5�      �� 5�      .R�5�   "   � $	��437��6'   $	��163��63   $��Center=�6@   $��Center=�6]   .+�5�   &   �� $��Center=�6,   $��UniformToFill=�6I   ��6a   �� *	SourceImg+�� 5�   &   $��Bottom=�61   .+�5�   *   �� $
��Wrap=�6K   
�������$��Century Gothic)�6r   $��22(�6�   $
��Bold"�6�   $��Bottom=�6�   $
��15,5q�6�   $
 Left=�6�   ��64   �� *Title+6�   5�   '   5�   #   5�      5�      �� 5�      -   5        $ Listbox_OneItemThird��5�      $
��Left=�6<   $
 Hand��6W   $	��158��6e   $��823,386,0,0q�6r   $	��Top=�6�   $	��438��6�   ��.  $��0q�5�   D   $��Hidden=�6X   $��Hidden=�5�      ��5�   �   �� *OneArticle3+��5�      �� 5�      .R�5�   "   � $	��438��6'   $	��158��63   $��Center=�6@   $��Center=�6]   .+�5�   &   �� $��Center=�6,   $��UniformToFill=�6I   ��6a   �� *	SourceImg+�� 5�   &   $��Bottom=�61   .+�5�   *   �� $
��Wrap=�6K   
�������$��Century Gothic)�6r   $��22(�6�   $
��Bold"�6�   $��Bottom=�6�   $
��15,5q�6�   $
 Left=�6�   ��64   �� *Title+6�   5�   '   5�   #   5�      5�      �� 5�      -   5        $ Listbox_OneLiner��5�      $
��Left=�68   $
 Hand��6S   $	��240��6a   $��261,579,0,0q�6n   $	��Top=�6�   $	��294��6�   ��.  $��0q�5�   D   $��Hidden=�6X   $��Hidden=�5�      ��5�   �   �� *OneArticle4+��5�      �� 5�      .R�5�   "   � $	��274��6'   $	��212��63   $��Center=�6@   $��Center=�6]   .+�5�   &   �� $	��Top=�61   .+�5�   *   �� $��2q�61   
���   �$	��274��6Y   $��3��6e   
���   �$	��Top=�6�   �� 5�   *   $
��Wrap=�6K   
���   �$��Century Gothic)�6r   $��18(�6�   $
��Bold"�6�   $	��Top=�6�   $��15q�6�   $
 Left=�6�   ��64   �� *Title+6�   �� 5�   *   $
��Wrap=�6L   
���  ��$��Century Gothic)�6q   $��16(�6�   $
��Bold"�6�   $	��Top=�6�   $��15q�6�   ��64   �� *Byline+6�   �� 5�   *   $��2q�61   
���   �$	��274��6Y   $��3��6e   
���   �$	��Top=�6�   5�   '   5�   #   5�      5�      �� 5�      -   5        $ Listbox_OneLiner2��5�      $
��Left=�69   $
 Hand��6T   $	��240��6b   $��594,579,0,0q�6o   $	��Top=�6�   $	��294��6�   ��.  $��0q�5�   D   $��Hidden=�6X   $��Hidden=�5�      ��5�   �   �� *OneArticle5+��5�      �� 5�      .R�5�   "   � $	��274��6'   $	��212��63   $��Center=�6@   $��Center=�6]   .+�5�   &   �� $	��Top=�61   .+�5�   *   �� $��2q�61   
���   �$	��274��6Y   $��3��6e   
���   �$	��Top=�6�   �� 5�   *   $
��Wrap=�6K   
���   �$��Century Gothic)�6r   $��18(�6�   $
��Bold"�6�   $	��Top=�6�   $��15q�6�   $
 Left=�6�   ��64   �� *Title+6�   �� 5�   *   $
��Wrap=�6L   
���  ��$��Century Gothic)�6q   $��16(�6�   $
��Bold"�6�   $	��Top=�6�   $��15q�6�   ��64   �� *Byline+6�   �� 5�   *   $��2q�61   
���   �$	��274��6Y   $��3��6e   
���   �$	��Top=�6�   5�   '   5�   #   5�      5�      �� 5�      -   5        $ Listbox_OneLiner3��5�      $
��Left=�69   $
 Hand��6T   $	��240��6b   $��938,579,0,0q�6o   $	��Top=�6�   $	��294��6�   ��.  $��0q�5�   D   $��Hidden=�6X   $��Hidden=�5�      ��5�   �   �� *OneArticle6+��5�      �� 5�      .R�5�   "   � $	��274��6'   $	��212��63   $��Center=�6@   $��Center=�6]   .+�5�   &   �� $	��Top=�61   .+�5�   *   �� $��2q�61   
���   �$	��274��6Y   $��3��6e   
���   �$	��Top=�6�   �� 5�   *   $
��Wrap=�6K   
���   �$��Century Gothic)�6r   $��18(�6�   $
��Bold"�6�   $	��Top=�6�   $��15q�6�   $
 Left=�6�   ��64   �� *Title+6�   �� 5�   *   $
��Wrap=�6L   
���  ��$��Century Gothic)�6q   $��16(�6�   $
��Bold"�6�   $	��Top=�6�   $��15q�6�   ��64   �� *Byline+6�   �� 5�   *   $��2q�61   
���   �$	��274��6Y   $��3��6e   
���   �$	��Top=�6�   5�   '   5�   #   5�      5�      �� 5�      $
��Left=�6   $	��299��67   $��
10,477,0,0q�6D   $	��Top=�6X   $	��230��6p   $i��cC:\Users\alf_b\Desktop\Spring 2019\Fall 2019\Senior Capstone - Finished\NewsToday\Pictures\Lobo.jpg��6|   �� 5�      $
��Left=�6    $��
18,280,0,0q�6;   $
��Wrap=�6O   $��LOBO SPIRIT��6c   $	��Top=�6v   $��72(�6�   $	��216��6�   $��
Harrington)�6�   $ Center=�6�   5�      5�      5�      5�      5�      