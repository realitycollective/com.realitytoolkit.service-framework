﻿// Copyright (c) Reality Collective. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using RealityCollective.ServiceFramework.Interfaces;
using UnityEngine;

namespace RealityCollective.ServiceFramework.Definitions
{
    [CreateAssetMenu(menuName = "Reality Collective/Service Framework/Scene Service Providers Profile", fileName = "SceneServiceProvidersProfile", order = (int)CreateProfileMenuItemIndices.ServiceProviders)]
    public class SceneServiceProvidersProfile : BaseServiceProfile<IService>
    {
        [SerializeField]
        [Tooltip("The selected scene name to load the services for.")]
        private string sceneName;

        public string SceneName => sceneName;
    }
}