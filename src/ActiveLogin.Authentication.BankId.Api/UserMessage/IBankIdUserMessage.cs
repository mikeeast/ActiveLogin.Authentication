using ActiveLogin.Authentication.BankId.Api.Models;

namespace ActiveLogin.Authentication.BankId.Api.UserMessage;

public interface IBankIdUserMessage
{
    MessageShortName GetMessageShortNameForCollectResponse(
        CollectStatus collectStatus,
        CollectHintCode hintCode,
        bool tokenStartRequired,
        bool accessedFromMobileDevice,
        bool usingQrCode);

    MessageShortName GetMessageShortNameForErrorResponse(ErrorCode errorCode);
}
