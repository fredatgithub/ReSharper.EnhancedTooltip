using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent]
	internal sealed class ConditionalLogicOperatorTypesMismatchErrorEnhancer : CSharpHighlightingEnhancer<ConditionalLogicOperatorTypesMismatchError> {

		protected override void AppendTooltip(ConditionalLogicOperatorTypesMismatchError highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("In order to be applicable as a short circuit operator a user-defined logical operator ('");
			colorizer.AppendDeclaredElement(highlighting.SignOperator, highlighting.Substitution, PresenterOptions.QualifiedName);
			colorizer.AppendPlainText("') must have the same return type as the type of its 2 parameters");
		}
		
		public ConditionalLogicOperatorTypesMismatchErrorEnhancer(
			[NotNull] TextStyleHighlighterManager textStyleHighlighterManager,
			[NotNull] CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			[NotNull] HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}