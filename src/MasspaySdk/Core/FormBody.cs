/**
 * MassPay API
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@masspay.io
 *
 * NOTE: This file is auto generated.
 * Do not edit the file manually.
 */
using System.Net;

namespace MasspaySdk.Core;

public class FormBody : IRequestBody
{
    private readonly IDictionary<string, object> _body;

    public FormBody(IDictionary<string, object> body)
    {
        _body = body;
    }

    public HttpContent GetHttpContent()
    {
        return new FormUrlEncodedContent(_body.Select(x => new KeyValuePair<string?, string?>(x.Key, x.Value?.ToString())));
    }
}
