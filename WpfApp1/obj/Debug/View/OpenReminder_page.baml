   M S B A M L   `   `   `  ����I  EWpfTaskmanager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfTaskmanagerWpfTaskmanager  5      +    %WpfTaskmanager.View.OpenReminder_page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfTaskmanager     5        N� WindowHeight$	  400Q�5	       N� WindowWidth$	 510Q�6    N� Title$ OpenReminder_page��5
      .��5      � ��5   
   �� 5       �� ImageSource$2 ,pack://application:,,,/images/background.jpg��6    � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   c� $��0��6   $��Right=�6   $	��Top=�6;   $��25��6S   .@�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $
��Edit��5      $��50��5      $��Right=�6   $
��Edit��5         SaveButtonStyle#��[  5      y�5      �� *EditButton_visibility+  	BoolToVis �� 	Converter# [ ��5      �� *Edit_Command+�� 5      -   5        $
��Save��5      $��50��5      $��Right=�6   $
��Save��5       #��[  5!      y�5"      �� *SaveButton_visibility+# [ ��5#      �� *SaveEditedReminder_Command+5$      5%      (  "System.Windows.Controls.DatePicker  5&   
   $��2��6   $��10,5,0,0q�6"   $	��Top=�64   ���#A64B00$
��Left=�5'   +   {�5(      �� *Element_IsEnabled+ �� Mode$ TwoWay=�   SelectedDate 5)      �� *SelectedReminder.Date+�� 5*   
   -   5        $��Topic��5*      $��3��6   $��
10,10,10,0q�5+      $	��Top=�6&   	 �� TextWrapping$
	 Wrap=�5,      ���#FF7373  TopicTextBoxStyle#��[ 5.      ��5/      �� *SelectedReminder.Topic+
 �� UpdateSourceTrigger$
 PropertyChanged=�$ TwoWay=� �� 
IsReadOnly 50      �� *TextBox_IsReadOnly+$
 PropertyChanged=�$ TwoWay=��� 51   
   -   5        $
��Text��51      $��Stretch=�6   $
	 Wrap=�52      
�������$��4��54      $��10 10 10 10q�6     TaskTextTextBoxStyle#��[ 55      ��56      �� *SelectedReminder.Text+$
 PropertyChanged=�$ TwoWay=� 57      �� *TextBox_IsReadOnly+$
 PropertyChanged=�$ TwoWay=�58      59      