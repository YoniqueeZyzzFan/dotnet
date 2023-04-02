﻿using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using RecruitmentAgency;

namespace MyServer.Tests;

public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Get_Values_ReturnsSuccess()
    {
        // Arrange
        var client = _factory.CreateClient(); //https://localhost:7144/

        // Act
        var response = await client.GetAsync("api/Company");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var companies = JsonConvert.DeserializeObject<List<Company>>(content);
        Assert.Equal(3, companies.Count());
    }
}
