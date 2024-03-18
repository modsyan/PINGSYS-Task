using MyRow = MySereneApp.Administration.LanguageRow;
using MyRequest = Serenity.Services.SaveRequest<MySereneApp.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;


namespace MySereneApp.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}