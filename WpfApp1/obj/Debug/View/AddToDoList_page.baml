   M S B A M L   `   `   `  ����I  EWpfTaskmanager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfTaskmanagerWpfTaskmanager  5      *    $WpfTaskmanager.View.AddToDoList_page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfTaskmanager     5        N� Title$  AddToDoList_page��5       N� WindowTitle$ Task Manager��6     N� WindowHeight$	 400Q�6<    N� WindowWidth$	 510Q�6O   .��5	      � ��5
   
   �� 5       �� ImageSource$2 ,pack://application:,,,/images/background.jpg��6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $
��0.5* �6   .+�5   
   c� $��0��6   $��Right=�6   $	��Top=�6;   $��35��6S   .@�5      �� $��50��6   $
��Save��6       SaveButtonStyle#��[  5      {�5      �� *SaveNew_ButtonVisibility+��5      �� *SaveNewList_Command+5      �� 5   
   $��1��6   $��	10 5 10 0q�6   $��40��5      $
��Left=�6   $��Topic:��5      �� 5   
   $��1��6   $��	55 5 10 0q�6    �� TextWrapping$
 Wrap=�5        TopicTextBoxStyle#��[ 5      ��5       �� *NewList.Topic+ �� Mode$ TwoWay=��� 5!   
   -   5        $��Goals��5!      $��2��6   $��Disabled=�5"      $��Stretch=�5#      ��5$      �� *NewList.Goals+ �� UpdateSourceTrigger$ PropertyChanged=�$ TwoWay=���5%      �� 5&      $2 ,pack://application:,,,/images/background.jpg��6   ��5(      �� 5)      .R�5*      �� 	 K� IsItemsHost	 . 
 �� Orientation$
 Vertical=�64   5+      ��5-      �� 5.      .R�5/      � $��
10 5 10 10q�6   .+�50      �� ��6#   �� *
GoalText+$ TwoWay=�51      52      54      �� 55   
   $��3��6   $��10 10 10 10q�6   $��90��56      $
��Left=�6   $��Add new goals:��57      �� 58   
   $��3��6   $��
105 5 10 0q�6   
�������$
 Wrap=�5:        TaskTextTextBoxStyle#��[ 5;      ��5<      �� *NewGoal.GoalText+$ TwoWay=��� 5=   
   $��4��6   $��40��6   $��20��6)   $
��Left=�65   $��	105 5 0 0q�5>      $��DemiBold"�6$   $��+��5?      ��6   �� *Add_ListItem+5@      5A      