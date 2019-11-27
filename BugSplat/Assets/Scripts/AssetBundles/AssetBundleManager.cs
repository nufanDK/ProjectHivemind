﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class AssetBundleManager : MonoBehaviour
{
    public static AssetBundleManager Instance;

    public string AssetBundleURL;

    public GameEvent BundledLoaded;

    protected AssetBundle _loadedBundle;


    virtual protected IEnumerator Start() {
        if (Instance == null) {
            DontDestroyOnLoad(transform.root.gameObject);

            yield return LoadBundle();

            LoadAllAssets();
        }
    }

    public IEnumerator LoadBundle() {
        var request = UnityWebRequestAssetBundle.GetAssetBundle(AssetBundleURL);
        yield return request.SendWebRequest();

        _loadedBundle = DownloadHandlerAssetBundle.GetContent(request);
    }

    public void UnloadBundle() {
        _loadedBundle.Unload(true);
    }

    public void LoadAllAssets() {
        var objects = _loadedBundle.LoadAllAssets();

        BundledLoaded?.Raise(gameObject);
    }

    public T GetAsset<T>(string assetName) where T : UnityEngine.Object {
        return _loadedBundle.LoadAsset<T>(assetName);
    }

    void OnDestroy() {
        _loadedBundle.Unload(true);
    }
}