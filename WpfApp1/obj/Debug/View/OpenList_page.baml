   M S B A M L   `   `   `  ����I  EWpfTaskmanager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfTaskmanagerWpfTaskmanager  5      '    !WpfTaskmanager.View.OpenList_page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfTaskmanager     5        N� WindowHeight$	  400Q�5	       N� WindowWidth$	 510Q�6    N� Title$ OpenList_page��5
      .��5      � ��5   
   �� 5       �� ImageSource$2 ,pack://application:,,,/images/background.jpg��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      .+�5   
   c� $��0��6   $��Right=�6   $	��Top=�6;   $��25��6S   .@�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $
��Edit��5      $��50��5      $��Right=�6   $
��Edit��5         SaveButtonStyle#��[  5      y�5      �� *EditButton_visibility+  	BoolToVis �� 	Converter# [ ��5      �� *Edit_Command+�� 5      -   5        $
��Save��5      $��50��5      $��Right=�6   $
��Save��5       #��[  5!      y�5"      �� *SaveList_ButtonVisibility+# [ ��5#      �� *SaveEditedList_Command+5$      5%      �� 5&   
   -   5        $��OpenedListTopic��5&      $��1��6)   $��10 10 10 10q�5'       �� TextWrapping$
 Wrap=�5(      ���#FF7373  TopicTextBoxStyle#��[ 5*      ��5+      �� *SelectedList.Topic+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=�
 �� 
IsReadOnly
 5,      �� *TextBox_IsReadOnly+$ PropertyChanged=�$	 TwoWay=��� 5-   
   -   5        $��Goals��5-      $��2��6   $��Disabled=�5.      $��Stretch=�5/       �� SelectedItem 50      �� *SelectedGoal+��51      �� *SelectedList.Goals+$ PropertyChanged=�$	 TwoWay=� � ContextMenu 52      �� 53      .@�54      m� $��Delete��6    m� Command 6/   �� *
DeleteGoal+ m� Icon 55      �� 56      $.��(pack://application:,,,/images/delete.jpg��6$   58      m� 59      $
��Edit��6    6-   �� *
EditGoal+ 5:      �� 5;      $,��&pack://application:,,,/images/edit.png��6$   5=      5>      ��5@      �� 5A      .R�5B      ��  K� IsItemsHost . $ Vertical=�64   5C      ��5E      �� 5F      $2 ,pack://application:,,,/images/background.jpg��6   ��5H      �� 5I      .R�5J      �� ��6   �� *
GoalText+$	 TwoWay=� d� 	IsChecked 5K      �� *	IsChecked+$	 TwoWay=�5L      5N      �� 5O   
   $��3��6   $��10 10 10 10q�6   $��90��5P      $
��Left=�6   $��DemiBold"�5R      $��Add new goals:��6&   y�5Q      �� *AddButton_visibility+# [ 5R   &   �� 5S   
   $��3��6   $��
105 5 10 0q�6   
�������$
 Wrap=�5T   %   y�5U      �� *TextBox_visibility+# [ ��5V      �� *NewGoal.GoalText+$	 TwoWay=��� 5W   
   $��4��6   $��40��6   $��20��6)   $
��Left=�5X      $��	105 5 0 0q�6,   $��+��5Z      y�5Y      �� *AddButton_visibility+# [ ��5Z      �� *	Edit_List+�� 5[   
   $��4��6   $��40��6   $��20��6)   $
��Left=�5\      $��	105 5 0 0q�6,   $
��Save��5^      y�5]      �� *EditGoal_ButtonVisibility+# [ ��5^       �� *SaveEdited_Goal+5_      5`      