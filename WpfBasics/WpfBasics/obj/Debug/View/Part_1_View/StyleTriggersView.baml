   M S B A M L   `   `   `  ����D  @WpfBasics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfBasics.View.Part_1_ViewWpfBasics.View.Part_1_View  5      2    ,WpfBasics.View.Part_1_View.StyleTriggersView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:WpfBasics.View.Part_1_View     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1142, Culture=neutral, PublicKeyToken=null@material1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   �� $��PropertyTrigger��6   $��0,0,0,51q�6+   $��1��6=   $��2��6J   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  �� Property � �� �� Value$ IsMouseOver��68   �� 5       � ��$
 Bold"�6;   5      P� 5       � �� . . �5      ��  � ��$ 	IsPressed��68   �� 5       � ��$
 Bold"�6;   5      5!      5#      �� 5%   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��5q�6;    � ToolTip$ 
Data Event��6F   .+�5&      �� -   5        $��TextBoxContent��5&      $	��150��6,   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Enter Password��69   $��Center=�6c   .��6~   ��5'      �� 5(      " ��6   .�5)      ��  � ��
 �  ��68    5*      �� 5+      
 �� Binding
 6*   ��  �� ElementName$ TextBoxContent�� �� Path$
 Text� �� Value password6c   .a�5,   "   ��  � ��
 � � �6@   5-      5/      .��50   !   51      �� 52      $��Center=�6   $��5q�64   ��53      �� 54      " ��6   .�55      ��  � ��$ Invalid Password��61    56      �� 57      
 6*   �� $ TextBoxContent��$
 Text� password6c   .a�58   "   ��  � ��$ Valid Password��6:   59      5;      5=      5?      �� 5A   
   $��3��6   .+�5B      �� $��Event Trigger Demo��6   $��25(�62   ��5C      �� 5D      " ��6    5E      :� 5F       :� RoutedEvent$ 
MouseEnter��6+   [�5G   "   �� 5H   &   .��5I   *   �� .��5J   .   W�  g� 	BeginTime$ 	0:0:0.250X�6>    �� TargetProperty$ FontSize�6T   	 W� To$ 50X�6y   5K   +   5L   '   5N      :� 5O      $ 
MouseLeave��6+   .[�5P   "   �� .��5Q   &   �� $ 	0:0:0.250X�61   $ FontSize�6G   .��5R   *   W� $ 25X�6:   5S   '   5T   #   5U      5W      5Y      5Z      5[      5\      