   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L5clr-namespace:System.Diagnostics;assembly=WindowsBaseSystem.Diagnostics  5      I EWpfTaskmanager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfTaskmanagerWpfTaskmanager 5      '   !WpfTaskmanager.View.OpenNote_page   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5      @d2http://schemas.microsoft.com/expression/blend/2008      5      Fdiag5clr-namespace:System.Diagnostics;assembly=WindowsBase      5      .localclr-namespace:WpfTaskmanager      5        N� WindowHeight$	  400Q�5
       N� WindowWidth$	 510Q�6    N� Title$ OpenNote_page��5       N� 
Background 5      �� 5   
    �� ImageSource$= 7pack://application:,,,/images/openedtask_background.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $��3* �6   .+�5   
   c� $��0��6   $��Right=�6   $	��Top=�6;   $��25��6S   .@�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $
��Edit��5      $��50��5      $��Right=�6   $
��Edit��5         SaveButtonStyle#��[  5      y�5      �� *EditButton_visibility+  	BoolToVis �� 	Converter# [ ��5      �� *Edit_Command+�� 5      -   5        $
��Save��5      $��50��5      $��Right=�6   $
��Save��5      #��[  5       y�5!      �� *SaveButton_visibility+# [ ��5"      �� *SaveEditedNote_Command+5#      5$      �� 5%   
   -   5        $��OpenedNoteTopic��5%      $��1��6)   $��10 10 10 10q�5&       �� TextWrapping$
 Wrap=�5'      ���#FF7373  TopicTextBoxStyle#��[ 5)      ��5*      �� *SelectedNote.Topic+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=� �� 
IsReadOnly 5+      �� *TextBox_IsReadOnly+$	 PropertyChanged=��� 5,   
   -   5        $��OpenedNoteText��5,      $	��Top=�6(   $��10 10 10 10q�5-      $
 Wrap=�5.        TaskTextTextBoxStyle#��[ 5/      $��2��50      $	��500��6    $	��300��6,   ��51      �� *SelectedNote.Text+$	 PropertyChanged=�$
 TwoWay=� 52      �� *TextBox_IsReadOnly+$	 PropertyChanged=�.��6a   53      54      55      