Public Class PredFrm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents PredCmb As System.Windows.Forms.ComboBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents OKBtn As System.Windows.Forms.Button
	Friend WithEvents ContainsTxt As System.Windows.Forms.TextBox
	Friend WithEvents ArrayTxt As System.Windows.Forms.TextBox
	Friend WithEvents FreetextTxt As System.Windows.Forms.TextBox
	Friend WithEvents FormsofTxt As System.Windows.Forms.TextBox
	Friend WithEvents IsAboutTxt As System.Windows.Forms.TextBox
	Friend WithEvents LikeTxt As System.Windows.Forms.TextBox
	Friend WithEvents LiteralTxt As System.Windows.Forms.TextBox
	Friend WithEvents DateaddTxt As System.Windows.Forms.TextBox
	Friend WithEvents MatchesTxt As System.Windows.Forms.TextBox
	Friend WithEvents NearTxt As System.Windows.Forms.TextBox
	Friend WithEvents NullTxt As System.Windows.Forms.TextBox
	Friend WithEvents RankByTxt As System.Windows.Forms.TextBox
	Friend WithEvents RankmethodTxt As System.Windows.Forms.TextBox
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PredFrm))
		Me.Label1 = New System.Windows.Forms.Label
		Me.PredCmb = New System.Windows.Forms.ComboBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.RankmethodTxt = New System.Windows.Forms.TextBox
		Me.RankByTxt = New System.Windows.Forms.TextBox
		Me.NullTxt = New System.Windows.Forms.TextBox
		Me.NearTxt = New System.Windows.Forms.TextBox
		Me.MatchesTxt = New System.Windows.Forms.TextBox
		Me.DateaddTxt = New System.Windows.Forms.TextBox
		Me.LiteralTxt = New System.Windows.Forms.TextBox
		Me.LikeTxt = New System.Windows.Forms.TextBox
		Me.IsAboutTxt = New System.Windows.Forms.TextBox
		Me.FormsofTxt = New System.Windows.Forms.TextBox
		Me.FreetextTxt = New System.Windows.Forms.TextBox
		Me.ContainsTxt = New System.Windows.Forms.TextBox
		Me.ArrayTxt = New System.Windows.Forms.TextBox
		Me.OKBtn = New System.Windows.Forms.Button
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(4, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(204, 40)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Select a WHERE Predicate to get more details about it as well as an example of ho" & _
		"w to use it."
		'
		'PredCmb
		'
		Me.PredCmb.Items.AddRange(New Object() {"ARRAY", "CONTAINS", "DATEADD", "FREETEXT", "FORMSOF", "ISABOUT", "LIKE", "LITERAL", "MATCHES", "NEAR", "NULL", "RANK BY", "RANKMETHOD"})
		Me.PredCmb.Location = New System.Drawing.Point(4, 44)
		Me.PredCmb.Name = "PredCmb"
		Me.PredCmb.Size = New System.Drawing.Size(204, 21)
		Me.PredCmb.TabIndex = 1
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.RankmethodTxt)
		Me.GroupBox1.Controls.Add(Me.RankByTxt)
		Me.GroupBox1.Controls.Add(Me.NullTxt)
		Me.GroupBox1.Controls.Add(Me.NearTxt)
		Me.GroupBox1.Controls.Add(Me.MatchesTxt)
		Me.GroupBox1.Controls.Add(Me.DateaddTxt)
		Me.GroupBox1.Controls.Add(Me.LiteralTxt)
		Me.GroupBox1.Controls.Add(Me.LikeTxt)
		Me.GroupBox1.Controls.Add(Me.IsAboutTxt)
		Me.GroupBox1.Controls.Add(Me.FormsofTxt)
		Me.GroupBox1.Controls.Add(Me.FreetextTxt)
		Me.GroupBox1.Controls.Add(Me.ContainsTxt)
		Me.GroupBox1.Controls.Add(Me.ArrayTxt)
		Me.GroupBox1.Location = New System.Drawing.Point(216, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(524, 416)
		Me.GroupBox1.TabIndex = 2
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Predicate Info:"
		'
		'RankmethodTxt
		'
		Me.RankmethodTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RankmethodTxt.Location = New System.Drawing.Point(4, 16)
		Me.RankmethodTxt.Multiline = True
		Me.RankmethodTxt.Name = "RankmethodTxt"
		Me.RankmethodTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.RankmethodTxt.Size = New System.Drawing.Size(516, 396)
		Me.RankmethodTxt.TabIndex = 12
		Me.RankmethodTxt.Text = "You can use the RANKMETHOD term to specify which statistical algorithm is used to" & _
		" rank the documents that match one or more of the ISABOUT match_terms. The synta" & _
		"x of the ISABOUT term when using RANKMETHOD is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ISABOUT ( <match_terms> RANKM" & _
		"ETHOD <rank_method> )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following shows the available rank methods and a br" & _
		"ief description of each." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "JACCARD COEFFICIENT: Ranking results are calculated " & _
		"from the relative proportion of matching terms, excluding any terms that are not" & _
		" matched. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "DICE COEFFICIENT: Ranking results are calculated from the frequency " & _
		"of multiple terms found together, compared with the probability they are found i" & _
		"n isolation. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INNER PRODUCT: Ranking results are calculated by using the integr" & _
		"al of the products of the ranks of the individual matching documents. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "MINIMUM:" & _
		" Ranking results are calculated from the lowest rank score from all the matching" & _
		" documents. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "MAXIMUM: Ranking results are calculated from the highest rank scor" & _
		"e from all the matching documents. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "When no RANKMETHOD is specified, the defa" & _
		"ult Jaccard Coefficient method is used." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example show" & _
		"s an ISABOUT term that specifies a RANKMETHOD:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS (" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """urn:schemas" & _
		"-microsoft-com:office:office#Description""," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "' ISABOUT (" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """computer"" WEIGHT (0.75" & _
		"), " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """software"":0.25" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & ") RANKMETHOD INNER PRODUCT '" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & ")"
		'
		'RankByTxt
		'
		Me.RankByTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RankByTxt.Location = New System.Drawing.Point(4, 16)
		Me.RankByTxt.Multiline = True
		Me.RankByTxt.Name = "RankByTxt"
		Me.RankByTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.RankByTxt.Size = New System.Drawing.Size(516, 396)
		Me.RankByTxt.TabIndex = 11
		Me.RankByTxt.Text = "The results from a query include both the rows returned by the query and the rank" & _
		" column, if included in the SELECT clause. The rank values are calculated by the" & _
		" Search engine, and are returned as integers in the range zero to 1000. To make " & _
		"the rank results more meaningful, the query can control how ranks are calculated" & _
		", and can also affect the returned rank values. Both operations are performed in" & _
		" the RANK BY clause. The syntax for the RANK BY clause is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ( <search_co" & _
		"ndition> ) " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "RANK BY [ ( ] <rank_specification> [ ) ]" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The RANK BY clause is a" & _
		"pplied to the search_condition immediately preceding it. The parentheses surroun" & _
		"ding the search_condition are required. The parentheses surrounding the rank_spe" & _
		"cification are optional. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "More than one RANK BY clause can be applied to a si" & _
		"ngle condition. Include additional RANK BY clauses one after the other using par" & _
		"entheses." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Note: Full-text predicates return rank values in the range 0 to 100" & _
		"0. Rank values for all documents matched by a non-full-text predicate are 1000. " & _
		"Modifications to the rank values should take this into account." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "There are two" & _
		" types of rank_specifications: WEIGHT and COERCION. The WEIGHT function applies " & _
		"a multiplier to the rank value for the returned row. The COERCION function can b" & _
		"e used to multiply, add, or set a specific rank value for the row." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Each rank_" & _
		"specification can include either zero or one WEIGHT function. Zero or more COERC" & _
		"ION functions can also be included. If both WEIGHT and COERCION functions are in" & _
		"cluded in a RANK BY clause, the WEIGHT function must be first." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WEIGHT Functio" & _
		"n" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The syntax of the WEIGHT function is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WEIGHT ( <weight_multipler> )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Not" & _
		"e: The CONTAINS and FREETEXT predicate column weighting features support a short" & _
		"hand format using a colon. The RANK BY clause does not support the shortened for" & _
		"m." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The multiplier must be a decimal fraction value from 0.001 to 1.000. The w" & _
		"eight value is multiplied by the value returned by the search_condition predicat" & _
		"e." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example WHERE clause uses the WEIGHT function to " & _
		"move documents having the word ""computer"" in the title higher than those having " & _
		"it the Content field:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "( ""urn:schemas.microsoft.com.fulltex" & _
		"tqueryinfo:contents""," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'computer' ) " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "RANK BY WEIGHT ( 0.25 )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "OR" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "( """ & _
		"urn:schemas-microsoft-com:office:office#Title""," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'computer' ) " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "RANK BY WEIGHT (" & _
		" 0.90 )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "There is a limitation when using RANK BY WEIGHT, it will not work wit" & _
		"h CONTAINS clauses that use Boolean conditions, for example:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "( ""urn:s" & _
		"chemas.microsoft.com.fulltextqueryinfo:contents"",  '      " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """computer"" and ""soft" & _
		"ware"" ' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "COERCION Function" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The rank coercion function can be used to change" & _
		" the returned rank value by adding, multiplying, or configuring it to a specific" & _
		" value. The syntax of the COERCION function is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "COERCION ( <coercion_operatio" & _
		"n> , <coercion_value> )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The coercion value must be an integer value, or a decim" & _
		"al value between 0 and 1. If a decimal value is supplied, only three digits of p" & _
		"recision are allowed." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following describes the available coercion_operatio" & _
		"n settings." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ABSOLUTE: The rank value returned is the value specified in the c" & _
		"oercion_value. The value must be from 0 to 1000. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ADD: The rank value returned " & _
		"is the sum of the original rank value and the specified coercion_value. The valu" & _
		"e must be from 0.001 to 1.0. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "MULTIPLY: The rank value returned is the product " & _
		"of the original rank value and the specified coercion_value. The value must be f" & _
		"rom 0.001 to 1.0. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Important: Search can return rank values only in the range" & _
		" of 0 to 1000." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example uses the COERCION function to set all do" & _
		"cuments with ""computer"" in the title to have a rank of 1000, while reducing by o" & _
		"ne-half the rank of documents containing both ""computer"" and ""software"" in the t" & _
		"itle." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS ( ""urn:schemas-microsoft-com:office:office#Title"" ," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'" & _
		"computer' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "RANK BY COERCION ( ABSOLUTE , 1000 )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "OR " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS ( ""urn:schemas-" & _
		"microsoft-com:office:office#Title"" ," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'""computer"" AND ""software""' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "RANK BY COE" & _
		"RCION ( MULTIPLY, 0.500 )"
		'
		'NullTxt
		'
		Me.NullTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.NullTxt.Location = New System.Drawing.Point(4, 16)
		Me.NullTxt.Multiline = True
		Me.NullTxt.Name = "NullTxt"
		Me.NullTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.NullTxt.Size = New System.Drawing.Size(516, 396)
		Me.NullTxt.TabIndex = 10
		Me.NullTxt.Text = "The NULL predicate indicates whether the document has a value for the indicated c" & _
		"olumn. The NULL predicate syntax is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE <column> IS [ NOT ] NULL" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The opti" & _
		"onal NOT keyword negates the result." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The column can be a regular or delimited" & _
		" identifier." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Important: To test whether a column has the NULL value, you must" & _
		" use the NULL predicate. It is not legal to use the NULL value in a comparison p" & _
		"redicate. ""WHERE column IS NULL"" is the proper method. ""WHERE column = NULL"" is " & _
		"not allowed." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example returns documents that have no " & _
		"related documents:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ""urn:schemas-microsoft-com:publishing:RelatedDocument""" & _
		" IS NULL"
		'
		'NearTxt
		'
		Me.NearTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.NearTxt.Location = New System.Drawing.Point(4, 16)
		Me.NearTxt.Multiline = True
		Me.NearTxt.Name = "NearTxt"
		Me.NearTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.NearTxt.Size = New System.Drawing.Size(516, 396)
		Me.NearTxt.TabIndex = 9
		Me.NearTxt.Text = "The NEAR term is used to specify that two content_search_terms must be relatively" & _
		" close to one another to be recognized as matching for the CONTAINS predicate. T" & _
		"he syntax for the NEAR term is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<match_term> NEAR | ~ <match_term>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The NEAR " & _
		"term can be represented by the keyword ""NEAR"" or by a tilde (~)." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "When the wor" & _
		"ds joined by NEAR in the query are found within 50 words of one another inside t" & _
		"he search column, the NEAR term is considered to match. The closer together the " & _
		"two words are, the higher the calculated rank for the NEAR term will be. The fur" & _
		"ther apart the two words are, the lower the rank will be." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following shows" & _
		" match_term types that can be used with a NEAR term in a CONTAINS predicate." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
		"EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Word: A single word without spaces or other punctuation. Double quota" & _
		"tion marks are not necessary." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ('" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " computer NEAR software)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'" & _
		")" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Phrase: Multiple words or including spaces. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ('" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  ""com" & _
		"puter software"" NEAR" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  hardware)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Wildcard: Words or phrases with the " & _
		"asterisk (*) added to the end. For more information, see Using Wildcards in the " & _
		"CONTAINS Predicate." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " (' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  ""compu*"" NEAR ""soft*""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The f" & _
		"ollowing example shows chaining of NEAR terms, using both the short and long for" & _
		"ms of the term:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS (' computer NEAR software ~ ""setup application"" " & _
		"')"
		'
		'MatchesTxt
		'
		Me.MatchesTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.MatchesTxt.Location = New System.Drawing.Point(4, 16)
		Me.MatchesTxt.Multiline = True
		Me.MatchesTxt.Name = "MatchesTxt"
		Me.MatchesTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.MatchesTxt.Size = New System.Drawing.Size(516, 396)
		Me.MatchesTxt.TabIndex = 8
		Me.MatchesTxt.Text = "The MATCHES predicate can perform complex pattern matches on text columns. It can" & _
		" perform ""group"" or ""count"" matches. Group matches search for alternative groups" & _
		" of characters in the column, while count matches search for a specified number " & _
		"of occurrences of a match pattern. The syntax for the MATCHES predicate is:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "W" & _
		"HERE MATCHES ( <column> , ' <group_match> | <count_match> ' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The column can be" & _
		" a regular or delimited identifier, and must be single-valued. That is, the colu" & _
		"mn cannot be a multivalued column." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The text that the MATCHES predicate search" & _
		"es for is specified by using a string literal, and must be enclosed in quotation" & _
		" marks. The MATCHES predicate can perform either group matching or count matchin" & _
		"g. You cannot mix the two matching styles. The following table shows the two mat" & _
		"ching styles." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Group matching: Consists of search patterns that are matched ze" & _
		"ro or more times. Also supports defining alternative patterns. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Count matching:" & _
		" Consists of search patterns that are matched a specified number of times. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "E" & _
		"scaping Special Characters: In the matches string, all the characters with speci" & _
		"al meaning must be ""escaped"" from their simple character meaning. The vertical b" & _
		"ar (|) character is the escape character, and must appear immediately before the" & _
		" special character. The special characters that must be escaped are the asterisk" & _
		" (*), the question mark (?), the plus sign (+), the right and left parentheses (" & _
		"( and )), the right and left braces ({ and }), and the right and left square bra" & _
		"ckets ([ and ]). When a comma (,) is used inside a pattern to delimit alternativ" & _
		"e patterns, the vertical bar must escape the comma." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Creating Search Patterns:" & _
		" A search pattern is the basic unit of text that the MATCHES predicate searches " & _
		"for in the specified column. When wildcards are in the MATCHES predicate, they a" & _
		"pply to the most recently defined pattern. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The plus sign is a wil" & _
		"dcard that matches one or more of the preceding pattern. The following pattern m" & _
		"atches values that contain one or more uppercase ""m"" characters:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'M|+'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "If mo" & _
		"re than one character appears before the wildcard, only the last character is af" & _
		"fected by the wildcard. The following example matches values that begin with ""so" & _
		"ftwar"" followed by one or more ""e"" characters:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'software|+'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "To increase the " & _
		"size of a pattern that applies to a wildcard beyond one character, enclose the p" & _
		"attern in escaped parentheses. For example, the following string matches columns" & _
		" that have one or more sequential occurrences of ""Comp."" This would match ""Comp," & _
		""" ""CompComp,"" ""CompCompComp,"" and other similar permutations." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'|(Comp|)|+' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
		"You can indicate alternatives inside a pattern by separating them with an escape" & _
		"d comma. For example, the following string matches columns that have one or more" & _
		" sequential occurrences of ""Computer"" or ""Software."" It would match ""Computer,"" " & _
		"""ComputerComputer,"" ""ComputerSoftware,"" ""SoftwareComputer,"" ""SoftwareSoftware,"" " & _
		"""SoftwareComputerComputerSoftwareSoftware,"" and so on." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'|(Computer|,Software|)|" & _
		"+' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "In addition to defining sequences of characters to include, a pattern can" & _
		" also define a range or set of characters to include or exclude from the pattern" & _
		". Place the desired characters inside escaped square brackets ([ and ]). To excl" & _
		"ude a range or set of characters, place a caret (^) as the first character insid" & _
		"e the escaped square brackets. Note that the caret does not need to be escaped. " & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "For example, the following string matches columns containing the letter c, f" & _
		"ollowed by a vowel (a, e, i, o, or u), followed by the letter p. The string will" & _
		" match ""cap,"" ""cep,"" ""cip,"" ""cop,"" or ""cup."" " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'c|[aeiou|]p' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Similarly, the " & _
		"following string matches columns that have one or more of the letters in the spe" & _
		"cified range, such as ""ca,"" ""cb,"" ""cc,"" ""caa,"" ""cab,"" ""cac,"" ""cba,"" ""cbbbbcccaaa" & _
		"a,"" and so on." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'c|[a-c|]|+' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Using Group Matching: A group_match search stri" & _
		"ng consists of one or more patterns and escaped wildcards. The following shows t" & _
		"he defined group_match wildcard characters and a brief description of each." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "*" & _
		" : Asterisk matches zero or more occurrences of the previous search pattern.  " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
		"? : Question mark matches zero or one occurrence of the previous search pattern." & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "+ : Plus sign matches one or more occurrences of the previous search pattern." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(…) : Parentheses delimit the search pattern if the pattern consists of more th" & _
		"an one character. They also surround a set of alternative patterns. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "{…} : Brac" & _
		"es delimit the count parameters in a count-matching string. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[…] : Square brack" & _
		"ets delimit a range or set of characters in a group-matching string. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & ", : Comma" & _
		" separates alternative patterns inside a group-matching pattern. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The MATCH" & _
		"ES predicate can have more than one group-matching, pattern-wildcard pair, but y" & _
		"ou cannot mix group-matching with count-matching." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example match" & _
		"es columns that have the word ""computer"" followed by zero or more occurrences of" & _
		" the number ""75."" It matches ""computer,"" ""computer75,"" ""computer7575,"" and so on" & _
		"." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'computer|(75|)|*'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example matches columns that have the wor" & _
		"d ""computer"" followed by zero or one ""s."" The pattern matches ""computer"" or ""com" & _
		"puters.""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'computers|?'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example matches columns that have the w" & _
		"ord ""soft"" and one or more occurrences of ""ware."" The pattern matches ""software," & _
		""" ""softwareware,"" ""softwarewareware,"" and so on." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'soft|(ware|)|+'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The follow" & _
		"ing example matches columns that have one or more sequential occurrences of ""Com" & _
		"puter"" or ""Software."" It matches ""Computer,"" ""ComputerComputer,"" ""ComputerSoftwa" & _
		"re,"" ""SoftwareComputer,"" ""SoftwareSoftware,"" ""SoftwareComputerComputerSoftwareSo" & _
		"ftware,"" and so on." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'|(Computer|,Software|)|+'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Using Count Matching: The MAT" & _
		"CHES predicate count matching style supports matching the search pattern a speci" & _
		"fic number of times, or a range of times. Braces ({…}) are used to indicate a co" & _
		"unt match. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "A count_match string consists of one or more patterns and count s" & _
		"pecifiers. You can specify a required number of matches by including the require" & _
		"d number in the braces. The MATCHES predicate can match counts from 0 to 256. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example matches values that contain the pattern ""software"" exact" & _
		"ly twice. That is, it will match ""softwaresoftware."" It will not match ""software" & _
		""" or ""softwaresoftwaresoftware.""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'|(software|)|{2|}'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "To specify that the pat" & _
		"tern must be found at least the specified number of times, follow the count with" & _
		" a comma. The following example will match ""computercomputer,"" ""computercomputer" & _
		"computer,"" and other similar permutations." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'|(computer|)|{2,|}'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Note: Inside" & _
		" a pattern, the comma must be escaped to indicate it is separating two alternati" & _
		"ves. The comma should not be escaped when it appears in a count specifier." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "To" & _
		" specify that the pattern must be matched within a range of occurrences, include" & _
		" the minimum and maximum count values in the braces, separated by a comma. The f" & _
		"ollowing example will match from 1 to 5 occurrences of the letter o in the word " & _
		"""computer."" It will match ""computer,"" ""coomputer,"" ""cooomputer,"" ""coooomputer,"" " & _
		"and ""cooooomputer.""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'co|{1,5|}mputer'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Remember that if the pattern is not su" & _
		"rrounded by escaped parentheses, the wildcard and count specifier apply to the i" & _
		"mmediately preceding single character."
		'
		'DateaddTxt
		'
		Me.DateaddTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DateaddTxt.Location = New System.Drawing.Point(4, 16)
		Me.DateaddTxt.Multiline = True
		Me.DateaddTxt.Name = "DateaddTxt"
		Me.DateaddTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.DateaddTxt.Size = New System.Drawing.Size(516, 396)
		Me.DateaddTxt.TabIndex = 7
		Me.DateaddTxt.Text = "The DATEADD function performs time and date calculations for matching properties " & _
		"having date types. Use the DATEADD function to obtain dates and times in a speci" & _
		"fied amount of time before the present. The following example shows the DATEADD " & _
		"function:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "DATEADD (DateTimeUnits, OffsetValue, DateTime)" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Parameters" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "DateT" & _
		"imeUnits: specify the units of the DateTimeValue parameter. This can be one of """ & _
		"YEAR"", ""QUARTER"", ""MONTH"", ""WEEK"", ""DAY"", ""HOUR"", ""MINUTE"", or ""SECOND"". This va" & _
		"lue is case-sensitive, and quotation marks are not required around the parameter" & _
		"." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "OffsetValue: specifies the time offset, in the units specified by the DateTim" & _
		"eUnits parameter. OffsetValue must be a negative integer. Positive values are no" & _
		"t supported." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "DateTime: is a timestamp from which to calculate the offset. This " & _
		"cannot be a date literal. It must be either GETGMTDATE or the result of another " & _
		"DATEADD function." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "NOTES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The DATEADD function can only be used in literal va" & _
		"lue comparisons and only on the right side of the comparison operator." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The GE" & _
		"TGMTDATE function returns the current date and time in Greenwich Mean Time. Reme" & _
		"mber that this value may not be the same as the local time of your Computer." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
		"Do not use the equals (=) comparison operator, because the internal time represe" & _
		"ntation can produce rounding errors that result in unexpected matching results." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "You can use multiple DATEADD functions to combine offset units." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example WHERE clause matches documents that were modified within " & _
		"the last five days:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ""DAV:getlastmodified"" <=DATEADD (DAY, -5, GETGMTDATE(" & _
		"))" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example WHERE clause matches documents that were modified wi" & _
		"thin the last two days and four hours:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ""DAV:getlastmodified"" <=DATEADD (D" & _
		"AY, -2, DATEADD (HOUR, -4, GETGMTDATE()))"
		'
		'LiteralTxt
		'
		Me.LiteralTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LiteralTxt.Location = New System.Drawing.Point(4, 16)
		Me.LiteralTxt.Multiline = True
		Me.LiteralTxt.Name = "LiteralTxt"
		Me.LiteralTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.LiteralTxt.Size = New System.Drawing.Size(516, 396)
		Me.LiteralTxt.TabIndex = 6
		Me.LiteralTxt.Text = "The literal value comparison uses standard comparison operators for matching a si" & _
		"ngle-valued column to a literal value." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "= : Equal to " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "!= or <> : N" & _
		"ot equal to " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "> : Greater than " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & ">= : Greater than or equal to " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "< : Less than " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<= : Less than or equal to " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Examples" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following are examples of the lite" & _
		"ral value comparison predicate:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ""urn:schemas-microsoft-com:office:offic" & _
		"e#Group"" = 'Accounting'" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ""urn:schemas-microsoft-com:publishing:IsCurrentVe" & _
		"rsion"" != TRUE" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE size >= 10000"
		'
		'LikeTxt
		'
		Me.LikeTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LikeTxt.Location = New System.Drawing.Point(4, 16)
		Me.LikeTxt.Multiline = True
		Me.LikeTxt.Name = "LikeTxt"
		Me.LikeTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.LikeTxt.Size = New System.Drawing.Size(516, 396)
		Me.LikeTxt.TabIndex = 5
		Me.LikeTxt.Text = "The LIKE predicate performs pattern-matching comparison on the specified column, " & _
		"by using the following syntax:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE <column> LIKE <wildcard_literal>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The co" & _
		"lumn can be a regular or delimited identifier, and must be single-valued. That i" & _
		"s, the column cannot be a multivalued column." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The wildcard_literal is a strin" & _
		"g literal, enclosed in quotation marks, and optionally containing wildcards. The" & _
		" match string can contain multiple wildcards if needed. The following shows the " & _
		"wildcards that the LIKE predicate recognizes." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "% (percent): Matches" & _
		" zero or more of any character. For example, 'comp%r' matches 'comp' followed by" & _
		" zero or more of any characters, ending in an r. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "_ (underscore): Matches any" & _
		" single character. For example, 'comp_ter' matches 'comp' followed by exactly on" & _
		"e of any character, followed by 'ter'.  " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[ ] (square brackets): Matches any s" & _
		"ingle character within the specified range or set. For example [a-z] specifies a" & _
		" range; [aeiou] specifies the set of vowels. 'comp[a-z]re' matches 'comp' follow" & _
		"ed by a single character in the range of lowercase a through lowercase z, follow" & _
		"ed by 're'. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "'comp[ao]' matches 'comp' followed by a single character that must" & _
		" be either a lowercase a or a lowercase o." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "[^ ] (caret):  Matches any single " & _
		"character that is not within the specified range or set. For example, [^a-z] spe" & _
		"cifies a range that excludes lowercase a through lowercase z; [^aeiou] specifies" & _
		" a set that excludes lowercase vowels. 'comp[^u]' matches 'comp' followed by any" & _
		" single character that is not a lowercase u. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Note: To match the wildcard c" & _
		"haracters percent, underscore, and the left square bracket, place the character " & _
		"inside square brackets. For example, to match the percent sign, use '[%]'"
		'
		'IsAboutTxt
		'
		Me.IsAboutTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.IsAboutTxt.Location = New System.Drawing.Point(4, 16)
		Me.IsAboutTxt.Multiline = True
		Me.IsAboutTxt.Name = "IsAboutTxt"
		Me.IsAboutTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.IsAboutTxt.Size = New System.Drawing.Size(516, 396)
		Me.IsAboutTxt.TabIndex = 4
		Me.IsAboutTxt.Text = "The ISABOUT term matches columns against a group of one or more search terms and " & _
		"has the following syntax:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "ISABOUT ( <components> ) [ RANKMETHOD <method> ]" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The optional RANKMETHOD term specifies the calculation method used to rank the " & _
		"documents that match one or more of the components. For more information about u" & _
		"sing RANKMETHOD, see RANKMETHOD Term. If no RANKMETHOD is specified, the default" & _
		" Jaccard Coefficient ranking method is used." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The ISABOUT term can have one or" & _
		" more components. The columns specified in the CONTAINS predicate are tested aga" & _
		"inst each component. The document will be added to the results if at least one o" & _
		"f the components matches. Commas separate multiple components." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The component " & _
		"part has the syntax:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<match_term> [ <weight_term> ]" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The optional weight_term" & _
		" can be used to change the relative importance of each term within the ISABOUT t" & _
		"erm. For more information about using weights in the ISABOUT term, see the ISABO" & _
		"UT Column Weighting section of this topic. If no weight term is applied, the def" & _
		"ault 1.0 weight is implied." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Word: A single word without spaces or " & _
		"other punctuation." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ('" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ISABOUT (""computer"",""software"")" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Phrase: Multiple words or including spaces. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ('" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ISABOUT" & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  (""computer software""," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  ""hardware"")" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Wildcard: Words or phrases wi" & _
		"th the asterisk (*) added to the end. For more information, see Using Wildcards " & _
		"in the CONTAINS Predicate." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " (' " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ISABOUT " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  (""compu*""," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """soft" & _
		"*"")" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "This will match ""computer"", ""computers"", ""computation"", and ""compulsor" & _
		"y""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The ISABOUT term ranks matching documents based on how closely each docume" & _
		"nt matches the set of match_terms in the query. You can use column weighting to " & _
		"place more importance on matching some match_terms compared to others. Each matc" & _
		"h_term in the ISABOUT term can have a weight value applied. The WEIGHT term has " & _
		"two alternative syntaxes. The long syntax is as follows:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<match_term> WEIGHT(" & _
		" <weight_value> )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The weight is applied to a single match_term, and is indicate" & _
		"d by the keyword ""WEIGHT"". " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The weight_value must be between 0 and 1.0, with " & _
		"no more than three decimal places. Specifying any weight values outside this ran" & _
		"ge will result in an error message. The weights are multiplied against the unwei" & _
		"ghted ranking value." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "If no weight is specified for a match_term, the default " & _
		"value 1.0 is implied." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Examples" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example applies weights to th" & _
		"e two ISABOUT match_terms, using the verbose and shortened weight indicators:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS (" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """urn:schemas-microsoft-com:office:office#Description""," & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "' ISA" & _
		"BOUT (" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """computer"" WEIGHT (0.75), " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & """software"":0.25" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  ) '" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & ")"
		'
		'FormsofTxt
		'
		Me.FormsofTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FormsofTxt.Location = New System.Drawing.Point(4, 16)
		Me.FormsofTxt.Multiline = True
		Me.FormsofTxt.Name = "FormsofTxt"
		Me.FormsofTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.FormsofTxt.Size = New System.Drawing.Size(516, 396)
		Me.FormsofTxt.TabIndex = 3
		Me.FormsofTxt.Text = "Matches a word and the inflectional versions of that word. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "FORMSOF ( <generat" & _
		"ion_type> , <match_words> )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The generation_type specifies how search chooses " & _
		"the alternative word forms. There are two values available: " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "INFLECTIONAL: choo" & _
		"ses alternative inflection forms for the match_words. If the word is a verb, alt" & _
		"ernative tenses and number are used. If the word is a noun, the singular, plural" & _
		", and possessive forms are used to detect matches. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "THESAURUS: chooses words th" & _
		"at have the same meaning, taken from a thesaurus dictionary." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The match_words " & _
		"part can be one or more words, separated by commas. The words cannot contain spa" & _
		"ces or punctuation, and therefore do not need to be enclosed in quotation marks." & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example searches for inflectional matches for the w" & _
		"ord ""run."" This example would match documents containing ""run,"" ""running,"" or ""r" & _
		"an.""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS ( ' FORMSOF ( INFLECTIONAL , ""run"" ) ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example " & _
		"searches for thesaurus matches for the word ""happy."" This example would match do" & _
		"cuments containing ""happy,"" in addition to words like ""glad,"" ""cheerful,"" and ""p" & _
		"leasant.""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "CONTAINS ( ' FORMSOF ( THESAURUS , ""happy"" ) ')"
		'
		'FreetextTxt
		'
		Me.FreetextTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FreetextTxt.Location = New System.Drawing.Point(4, 16)
		Me.FreetextTxt.Multiline = True
		Me.FreetextTxt.Name = "FreetextTxt"
		Me.FreetextTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.FreetextTxt.Size = New System.Drawing.Size(516, 396)
		Me.FreetextTxt.TabIndex = 2
		Me.FreetextTxt.Text = "Searches for documents that match the meaning of the search phrase. Related words" & _
		" and similar phrases will match, with the rank column calculated based on how cl" & _
		"osely the document matches the search phrase. When searching, the FREETEXT predi" & _
		"cate locates documents containing one or more of the search terms. The terms nee" & _
		"d not appear in any particular order. Documents that contain more of the terms t" & _
		"han other documents may have higher rank column values." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The follow" & _
		"ing example searches for documents containing ""computer,"" ""software,"" ""hardware," & _
		""" or combinations of those words:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE FREETEXT ( 'computer software hardware'" & _
		" )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "You cannot use both single word and phrase matching in the same FREETEXT p" & _
		"redicate. You can use multiple FREETEXT predicates to perform that function. The" & _
		" following example searches for documents containing both the word ""computer"" an" & _
		"d the phrase ""software development kit"":" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE FREETEXT ( 'computer ') AND" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "FRE" & _
		"ETEXT (' ""software development kit"" ' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "When performing queries with contract" & _
		"ions, you must escape the quotation mark in the contraction when using FREETEXT," & _
		" but not when using CONTAINS. For example, the following syntax will fail." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHER" & _
		"E FREETEXT ( *,'""We'll always have Paris""' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The correct syntax includes two " & _
		"single quotations, not a double quotation. For example, the following syntax wil" & _
		"l succeed." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE FREETEXT ( *,'""We''ll always have Paris""' )"
		'
		'ContainsTxt
		'
		Me.ContainsTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ContainsTxt.Location = New System.Drawing.Point(4, 16)
		Me.ContainsTxt.Multiline = True
		Me.ContainsTxt.Name = "ContainsTxt"
		Me.ContainsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.ContainsTxt.Size = New System.Drawing.Size(516, 396)
		Me.ContainsTxt.TabIndex = 0
		Me.ContainsTxt.Text = "Supports complex searches for terms in document text columns (for example, title," & _
		" contents). Can search for inflected forms of the search terms, test for proximi" & _
		"ty of the terms, and perform logical comparisons. Search terms can include wildc" & _
		"ards." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Word: A single word without spaces or other punctuation. Dou" & _
		"ble quotation marks are not necessary. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS ('computer')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Phrase: " & _
		"Multiple words or including spaces." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(' ""computer software"" ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Or, to use a double quote mark:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(' ""computer """"science"""" "" ')" & _
		"" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Wildcard: Words or phrases with the asterisk (*) added to the end. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE" & _
		" CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(' ""compu*"" ')" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "This will match ""computer"", ""computers"", ""computation" & _
		""", and ""compulsory""" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Boolean: Words, phrases, and wildcard strings combined " & _
		"by using the Boolean operators AND, OR, and NOT. Enclose the Boolean terms in do" & _
		"uble quotation marks." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(' ""computer monitor"" AND " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " ""software pr" & _
		"ogram"" AND" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "   ""install component"" ' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " (' ""computer"" AND " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " " & _
		"""software"" AND " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "  ""install"" ' )" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE CONTAINS" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "(' ""computer software instal" & _
		"l"" ')"
		'
		'ArrayTxt
		'
		Me.ArrayTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ArrayTxt.Location = New System.Drawing.Point(4, 16)
		Me.ArrayTxt.Multiline = True
		Me.ArrayTxt.Name = "ArrayTxt"
		Me.ArrayTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.ArrayTxt.Size = New System.Drawing.Size(516, 396)
		Me.ArrayTxt.TabIndex = 1
		Me.ArrayTxt.Text = "Columns can have multiple values, and those multivalued columns can be compared u" & _
		"sing the ARRAY comparison predicate. An error is returned if the column referenc" & _
		"e is not a multivalued column. The column data type must be compatible with the " & _
		"elements of the comparison_list. If necessary, the column reference can be cast " & _
		"as another data type." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "EXAMPLES:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The following example checks whether documen" & _
		"ts are in the ""Finance"" or ""Planning"" categories:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "WHERE ""urn:schemas-microsof" & _
		"t-com:publishing:Categories"" = " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "SOME ARRAY [ 'Finance' , 'Planning' ]"
		'
		'OKBtn
		'
		Me.OKBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.OKBtn.Location = New System.Drawing.Point(4, 396)
		Me.OKBtn.Name = "OKBtn"
		Me.OKBtn.TabIndex = 3
		Me.OKBtn.Text = "OK"
		'
		'PredFrm
		'
		Me.AcceptButton = Me.OKBtn
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(740, 421)
		Me.Controls.Add(Me.OKBtn)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.PredCmb)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "PredFrm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "WHERE Predicates"
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub PredCmb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PredCmb.SelectedIndexChanged

		Select Case PredCmb.Text
			Case "ARRAY"
				ArrayTxt.BringToFront()
			Case "CONTAINS"
				ContainsTxt.BringToFront()
			Case "DATEADD"
				DateaddTxt.BringToFront()
			Case "FREETEXT"
				FreetextTxt.BringToFront()
			Case "FORMSOF"
				FormsofTxt.BringToFront()
			Case "ISABOUT"
				IsAboutTxt.BringToFront()
			Case "LIKE"
				LikeTxt.BringToFront()
			Case "LITERAL"
				LiteralTxt.BringToFront()
			Case "MATCHES"
				MatchesTxt.BringToFront()
			Case "NEAR"
				NearTxt.BringToFront()
			Case "NULL"
				NullTxt.BringToFront()
			Case "RANK BY"
				RankByTxt.BringToFront()
			Case "RANKMETHOD"
				RankmethodTxt.BringToFront()
		End Select

	End Sub

	Private Sub PredFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		'set CONTAINS to be the default
		PredCmb.Text = "CONTAINS"
		ContainsTxt.BringToFront()

	End Sub

	Private Sub OKBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBtn.Click
		Me.Hide()
	End Sub

	Private Sub PredFrm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

		e.Cancel = True
		Me.Hide()

	End Sub

End Class

